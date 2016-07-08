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

                this.currentPlayer.PawnsAtHome = 
                    this.currentPlayer.Pawns.Where(x => x.IsAtHome)
                    .Select(x => x).ToList().Count;

                if (this.currentPlayer.Pawns[this.currentPlayer.SelectedPawn].IsAtHome 
                    && this.currentPlayer.StepsLeft < DiceConstants.MaxStandart 
                    && this.currentPlayer.PawnsAtHome < PlayerConstants.PawnsPerPlayer)
                {
                    this.GameState = GameStateType.SelectPawn;
                }
                else
                {
                    this.players[turn].PawnsAtHome--;
                    this.GameState = GameStateType.MovePawn;
                    
                }

            }
        }

        private async void HandleDiceClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == null)
                return;

            switch (b.Name)
            {
                case "btnDiceStandart":
                    {
                        int val = this.diceStandart.Throw(rnd);

                        this.lblStandart.Text = $"{val}";

                        if (val < DiceConstants.MaxStandart && currentPlayer.PawnsAtHome == PlayerConstants.PawnsPerPlayer)
                        {

                            if (this.curPlayerInitialThrows > 1)
                            {
                                this.curPlayerInitialThrows--;
                                this.GameState = GameStateType.ThrowNormal;

                            }
                            else
                            {
                                this.curPlayerInitialThrows--;
                                this.GameState = GameStateType.ChangePlayerTurn;
                            }
                            
                            break;
                        }        

                        this.players[turn].StepsLeft = val;
                        
                        this.GameState = GameStateType.SelectPawn;
                        break;
                    }
                case "btnDiceNine":
                    {
                        int val = this.diceNine.Throw(rnd);

                        this.players[turn].StepsLeft = -1 * val;
                        this.lblNine.Text = $"{val}";

                        this.GameState = GameStateType.SelectPawn;
                        break;
                    }
                case "btnDiceMama":
                    {
                        int val = this.diceMama.Throw(rnd);

                        this.players[turn].StepsLeft = val;
                        this.lblMama.Text = $"{val}";

                        this.GameState = GameStateType.SelectPawn;
                        break;
                    }
                case "btnDiceCatapult":
                    {
                        int val = this.diceCatapult.Throw(rnd);
                        this.players[turn].StepsLeft = -1 * val;
                        this.lblCatapult.Text = $"{val}";
                        this.GameState = GameStateType.MovePawn;
                        break;
                    }
                case "btnWheel":
                    {
                        // TODO: sled kato koleloto se zavyrti
                        // rezultatyt trqbwa da se pazi w pole
                        // i ottam natatyk da se sluchwat nqkvi neshta :D

                        Wheel.Spin(b, this.rnd);
                        // TODO: TO BE FIXED
                        await Task.Delay(10000);
                        this.spinResult = (WheelType)int.Parse(b.Name[b.Name.Length - 1].ToString());
                        b.Name = "btnWheel";
                        GetResultFromWheel();
                        this.GameState = GameStateType.RotateWheel;
                       // this.UpdateControls(false, false, false, false, false);
                        this.GameState = GameStateType.ChangePlayerTurn;
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
                        }
                    }
                }
            }
        }

        public IList<Field> GetFinishFromColor(ColorType col)
        {
            return col == ColorType.Red ? redFinish :
                   col == ColorType.Green ? greenFinish :
                   col == ColorType.Yellow ? yellowFinish :
                   col == ColorType.Blue ? blueFinish : redFinish;
        }
    }
}
