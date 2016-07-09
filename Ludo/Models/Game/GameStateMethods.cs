﻿using Ludo.Constants;
using Ludo.Enumerations;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        private void DoInitPlayerTurn()
        {
            this.currentPlayer = this.players[turn];
            if (this.currentPlayer.IsSleeping)
            {
                this.currentPlayer.IsSleeping = false;
                this.DoChangePlayerTurn();
            }
            else
            {
                this.lblTurn.Text = this.currentPlayer.Name;
                this.lblTurn.BackColor = ColorConstants.Colors[(int)this.currentPlayer.Color];

                //we may need this, depending on what is less ugly
                //this.lblStandart.Text = "";

                this.lblEscapedCount.Text = $"x{this.currentPlayer.PawnsEscaped}";
                this.pbEscapedPawn.BackgroundImage =
                    this.currentPlayer.Color == ColorType.Red ? Ludo.Properties.Resources.PawnRed :
                    this.currentPlayer.Color == ColorType.Green ? Ludo.Properties.Resources.PawnGreen :
                    this.currentPlayer.Color == ColorType.Yellow ? Ludo.Properties.Resources.PawnYellow :
                    this.currentPlayer.Color == ColorType.Blue ? Ludo.Properties.Resources.PawnBlue :
                        Ludo.Properties.Resources.PawnRed;

                this.btnWheel.Name = "btnWheel";
                this.UpdateControls(false, false, false, false, false);
                this.UpdatePawns(false, false);
                this.BringPawnsToFront();

                if(this.currentPlayer.PawnsAtHome == PlayerConstants.PawnsPerPlayer)
                {
                    this.curPlayerInitialThrows = DiceConstants.ThrowsIfAllAtHome;
                }

                this.GameState = GameStateType.ThrowNormal;
            }
        }

        private void DoChangePlayerTurn()
        {
            this.turn++;

            if(this.turn >= this.playerCount)
            {
                this.turn = 0;
            }

            this.GameState = GameStateType.InitPlayerTurn;
        }

        private void DoSelectPawn(Player p)
        {
            this.UpdateControls(false, false, false, false, false);
            this.UpdatePawns(true, false);
        }

        private async void DoMovePawn(Player p)
        {
            Pawn pawn = p.Pawns[p.SelectedPawn];

            bool atHome = pawn.IsAtHome;

            pawn.Move(this.playground, GetFinishFromColor(pawn.Color), Math.Abs(p.StepsLeft), p.StepsLeft < 0);

            if (!atHome)
                await Task.Delay((p.StepsLeft * PawnConstants.DisplayDelay));

            if (pawn.CurrentField.Type == FieldType.Nine)
            {
                this.gameState = GameStateType.ThrowNine;
            } else if (pawn.CurrentField.Type == FieldType.Special)
            {
                this.UpdateControls(false, false, false, false, true);
                this.GameState = GameStateType.RotateWheel;
            }
            else
            {
                this.GameState = GameStateType.ChangePlayerTurn;
            }

            p.StepsLeft = 0;
        }

        private void DoThrowNormal()
        {
            this.UpdateControls(true, false, false, false, false);
            this.UpdatePawns(false, false);
        }

        private void DoThrowMama()
        {
            this.UpdateControls(false, true, false, false, false);
            this.UpdatePawns(false, false);
        }

        private void DoThrowCatapult()
        {
            this.UpdateControls(false, false, false, true, false);
            this.UpdatePawns(false, false);
        }

        private void DoThrowNine()
        {
            this.UpdateControls(false, false, true, false, false);
            this.UpdatePawns(false, false);
        }

        private void DoRotateWheel()
        {
            this.UpdateControls(false, false, false, false, true);
            this.UpdatePawns(false, false);
        }

        private void DoWheelPlaceBomb()
        {
            this.UpdateControls(false, false, false, false, false);
            this.UpdatePawns(false, false);
        }
        private void DoWheelPlaceSleep()
        {
            this.UpdateControls(false, false, false, false, false);
            this.UpdatePawns(false, false);
        }

        private void DoWheelPlaceCatapult()
        {
            this.UpdateControls(false, false, false, false, false);
            this.UpdatePawns(false, false);
        }

        private void DoWheelSwitchPawns()
        {
            this.UpdateControls(false, false, false, false, false);
            this.UpdatePawns(false, true);
        }

        private void DoMissTurn()
        {
            this.UpdateControls(false, false, false, false, false);
            this.UpdatePawns(false, false);
            this.currentPlayer.IsSleeping = true;
            Thread.Sleep(1000);
            this.GameState = GameStateType.ChangePlayerTurn;
        }
    }
}
