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
using Ludo.Models.Dices;
using Ludo.Contracts;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        private List<Player> players;
        private Player currentPlayer;
        private IList<Field> playground;
        private int turn;
        private int playerCount;
        public event GameStateChanged OnStateChanged;
        private GameStateType gameState;
        private IDice diceStandart;
        private IDice diceNine;
        private IDice diceMama;
        private IDice diceCatapult;
        private Random rnd;
        private int curPlayerInitialThrows;
        private IList<Field> redFinish;
        private IList<Field> greenFinish;
        private IList<Field> yellowFinish;
        private IList<Field> blueFinish;
        private WheelType spinResult;

        public Game(Dictionary<ColorType, string> dict)
        {
            InitializeComponent();
            
            this.players = new List<Player>();
            this.playground = Playground.GetPlayground();
            this.OnStateChanged += GameStateHub;
            this.diceStandart = new DiceStandart();
            this.diceMama = new DiceMama();
            this.diceNine = new DiceNine();
            this.diceCatapult = new DiceCatapult();
            this.rnd = new Random();
            this.lblStandart.Text = "";
            this.lblCatapult.Text = "";
            this.lblNine.Text = "";
            this.lblMama.Text = "";
            this.curPlayerInitialThrows = 0;
            this.redFinish = Playground.GetFinish(ColorType.Red);
            this.greenFinish = Playground.GetFinish(ColorType.Green);
            this.yellowFinish = Playground.GetFinish(ColorType.Yellow);
            this.blueFinish = Playground.GetFinish(ColorType.Blue);

            for (int i = 0; i < PlayerConstants.MaxPlayers; i++)
            {
                if (dict.ContainsKey((ColorType)i))
                {
                    players.Add(new Player(dict[(ColorType)i], (ColorType)i));
                }
                else
                {
                    this.HideUnusedPawns((ColorType)i);
                }
            }

            this.playerCount = players.Count;
            this.turn = 0;

            this.players.ForEach(x =>
            {
                x.Pawns.ForEach(y => y.OnPawnChange += DisplayNewPawnPos);
            });
            
            this.players.ForEach(x => x.Pawns.ForEach(f => f.CurrentField = x.Home.FindEmptyHomeField()));

            this.GameState = GameStateType.InitPlayerTurn;
        }

        private void pbEscapedPawn_Click(object sender, EventArgs e)
        {

        }
    }
}
