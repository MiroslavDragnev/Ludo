using Ludo.Constants;
using Ludo.Enumerations;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        //public static Image RotateImage(Image img, float rotationAngle)
        //{
        //    //create an empty Bitmap image
        //    Bitmap bmp = new Bitmap(img.Width, img.Height);

        //    //turn the Bitmap into a Graphics object
        //    Graphics gfx = Graphics.FromImage(bmp);

        //    //now we set the rotation point to the center of our image
        //    gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

        //    //now rotate the image
        //    gfx.RotateTransform(rotationAngle);

        //    gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

        //    //set the InterpolationMode to HighQualityBicubic so to ensure a high
        //    //quality image once it is transformed to the specified size
        //    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

        //    //now draw our new image onto the graphics object
        //    gfx.DrawImage(img, new Point(0, 0));

        //    //dispose of our Graphics object
        //    gfx.Dispose();

        //    //return the image
        //    return bmp;
        //}

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
                this.currentPlayer.PawnsAtHome = this.currentPlayer.Pawns.Where(x => x.IsAtHome).Select(x => x).ToList().Count;
                if (this.currentPlayer.Pawns[this.currentPlayer.SelectedPawn].IsAtHome && this.currentPlayer.StepsLeft < 6 && this.currentPlayer.PawnsAtHome<4)
                {
                    this.GameState = Enumerations.GameStateType.SelectPawn;
                    
                }
                else
                {
                    this.GameState = GameStateType.MovePawn;
                }

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
                case "btnWheel":
                    {
                        b.Name = "btnWheel1";
                        Wheel.Spin(b, this.rnd);
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
