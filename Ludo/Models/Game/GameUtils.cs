using Ludo.Constants;
using Ludo.Enumerations;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
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
        public void DisplayNewPawnPos(object sender, EventArgs e)
        {
            Pawn p = sender as Pawn;

            foreach (Control C in this.Controls)
            {
                if (C is Button && C.Name == p.PawnName)
                {
                    C.Location = new Point(p.CurrentField.XPos, p.CurrentField.YPos);
                }
            }
        }

        private void HandlePawnClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b != null)
            {
                this.currentPlayer.SelectedPawn =
                    this.currentPlayer.Pawns.IndexOf(
                    (from pawn in this.currentPlayer.Pawns
                     where pawn.PawnName == b.Name
                     select pawn).First());

                //less ugly option
                //for (int i = 0; i < PlayerConstants.PawnsPerPlayer; i++)
                //{
                //    if(this.currentPlayer.Pawns[i].PawnName == b.Name)
                //    {
                //        this.currentPlayer.SelectedPawn = i;
                //        break;
                //    }
                //}

                this.GameState = GameStateType.MovePawn;
            }
        }

        private void HandleDiceClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == null)
                return;

            switch (b.Name)
            {
                case "btnDiceStandart":
                    {
                        this.players[turn].StepsLeft =
                            this.diceStandart.Throw(rnd);
                        this.GameState = GameStateType.SelectPawn;
                        break;
                    }
            }
        }

        private void DiceEnabledChanged(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == null)
                return;

            switch (b.Name)
            {
                case "btnDiceMama":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.BigMama :
                            global::Ludo.Properties.Resources.BigMamaDis;

                        break;
                    }
                case "btnDiceNine":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Nine :
                            global::Ludo.Properties.Resources.NineDis;
                        break;
                    }
                case "btnDiceStandart":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Standart :
                            global::Ludo.Properties.Resources.StandartDis;
                        break;
                    }
                case "btnDiceCatapult":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Catapult :
                            global::Ludo.Properties.Resources.CatapultDis;
                        break;
                    }
                case "btnWheel":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Wheel :
                            global::Ludo.Properties.Resources.WheelDis;
                        break;
                    }
            }
        }

        public void UpdateControls(bool standart, bool mama, bool nine, bool catapult, bool wheel)
        {
            this.btnDiceNine.Enabled = nine;
            this.btnDiceCatapult.Enabled = catapult;
            this.btnDiceMama.Enabled = mama;
            this.btnDiceStandart.Enabled = standart;
            this.btnWheel.Enabled = wheel;
        }

        public void UpdatePawns(bool curPlayerPawnsEnabled)
        {
            bool enable = false;

            foreach (Control C in this.Controls)
            {
                if (C is Button)
                {
                    foreach (var plr in this.players)
                    {
                        enable = (plr == currentPlayer && curPlayerPawnsEnabled);

                        foreach (var p in plr.Pawns)
                        {
                            if (C.Name == p.PawnName)
                            {
                                C.Enabled = enable;
                            }
                        }
                    }
                }
            }
        }

        public void HideUnusedPawns(ColorType color)
        {
            foreach (Control C in this.Controls)
            {
                if (C is Button)
                {
                    for (int i = 0; i < PlayerConstants.PawnsPerPlayer; i++)
                    {
                        if (C.Name == $"{PawnConstants.PawnNames[(int)color]}{i}")
                        {
                            C.Hide();
                            //C.Location = new Point(9999, 9999);
                        }
                    }
                }
            }
        }
    }
}
