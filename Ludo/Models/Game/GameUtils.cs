using Ludo.Constants;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        public void DisplayNewPawnPos(object sender, EventArgs e)
        {
            Pawn p = sender as Pawn;

            foreach (Control C in this.Controls)
            {
                if (C is Button //C.GetType() == typeof(Button)
                    && C.Name == p.PawnName)
                {
                    //Point location = C.Location;
                    //location.X = p.CurrentField.XPos;
                    //location.Y = p.CurrentField.YPos;
                    //C.Location = location;
                    C.Location = new Point(p.CurrentField.XPos, p.CurrentField.YPos);
                }
            }
        }

        private void HandlePawnClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b != null)
            {
                var name = b.Name;

                for (int i = 0; i < players.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (players[i].Pawns[j].PawnName == name)
                        {
                            players[i].Pawns[j].Move(playground, players[i].StepsLeft);
                        }
                    }
                }
            }
        }

        private void DiceEnabledChanged(object sender, EventArgs e)
        {
            Button b = sender as Button;

            switch(b.Name)
            {
                case "diceMama":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.BigMama :
                            global::Ludo.Properties.Resources.BigMamaDis;

                        break;
                    }
                case "diceNine":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Nine :
                            global::Ludo.Properties.Resources.NineDis;
                        break;
                    }
                case "diceStandart":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Standart :
                            global::Ludo.Properties.Resources.StandartDis;
                        break;
                    }
                case "diceCatapult":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Catapult :
                            global::Ludo.Properties.Resources.CatapultDis;
                        break;
                    }
            }
        }

        public void UpdateLabel(Player p)
        {
            this.btnTurn.Text = p.Name;
            this.btnTurn.BackColor = ColorConstants.Colors[(int)p.Color];
        }

        public void InitializePlayerTurn(Player P)
        {
            this.diceNine.Enabled = false;
            this.diceCatapult.Enabled = false;
            this.diceMama.Enabled = false;
            this.diceStandart.Enabled = true;


        }
    }
}
