using Ludo.Constants;
using Ludo.Enumerations;
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

        //public void NewPawnPos(Pawn p)
        //{
        //    foreach (Control C in this.Controls)
        //    {
        //        if (C is Button //C.GetType() == typeof(Button)
        //            && C.Name == p.PawnName)
        //        {
        //            //Point location = C.Location;
        //            //location.X = p.CurrentField.XPos;
        //            //location.Y = p.CurrentField.YPos;
        //            //C.Location = location;
        //            C.Location = new Point(p.CurrentField.XPos, p.CurrentField.YPos);
        //        }
        //    }
        //}

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
                            //players[i].Pawns[j].Move(playground, players[i].StepsLeft);
                            players[i].SelectedPawn = j;
                            players[i].StepsLeft = 5;
                            this.GameState = GameStateType.MovePawn;
                        }
                    }
                }
            }
        }

        private void DiceEnabledChanged(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == null)
                return;

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
                case "wheel":
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
            this.diceNine.Enabled = nine;
            this.diceCatapult.Enabled = catapult;
            this.diceMama.Enabled = mama;
            this.diceStandart.Enabled = standart;
            this.wheel.Enabled = wheel;
        }

        public void UpdatePawns(bool curPlayerPawnsEnabled)
        {
            bool enable = false;

            foreach (Control C in this.Controls)
            {
                if (C is Button)
                {
                    foreach(var plr in this.players)
                    {
                        enable = plr == this.players[turn] ? true : false;
                        if (!curPlayerPawnsEnabled) enable = false;

                        foreach(var p in plr.Pawns)
                        {
                            if(C.Name == p.PawnName)
                            {
                                C.Enabled = enable;
                            }
                        }
                    }
                }
            }
        }
    }
}
