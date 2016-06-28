using Ludo.Enumerations;
using Ludo.Extensions;
using Ludo.Models;
using Ludo.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        private List<Player> players;
        private List<Field> playground;
        private int turn;
        private int playerCount;

        public Game(Dictionary<ColorType, string> dict)
        {
            InitializeComponent();
            
            this.players = new List<Player>();
            this.playground = Playground.GetPlayground();

            for (int i = 0; i < 4; i++)
                if (dict.ContainsKey((ColorType)i))
                    players.Add(new Player(dict[(ColorType)i], (ColorType)i));

            this.playerCount = players.Count;
            this.turn = 0;

            UpdateLabel(players[turn]);

            this.players.ForEach(x =>
            {
                x.Pawns.ForEach(y => y.OnPawnChange += DisplayNewPawnPos);
            });

            this.players.ForEach(x => x.Pawns.ForEach(f => f.CurrentField = x.Home.FindEmptyHomeField()));

            InitializePlayerTurn(players[turn]);
        }
    }
}
