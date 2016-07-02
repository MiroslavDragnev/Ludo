using Ludo.Constants;
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

            this.btnTurn.Text = this.currentPlayer.Name;
            this.btnTurn.BackColor = ColorConstants.Colors[(int)this.currentPlayer.Color];

            this.UpdateControls(false, false, false, false, false);
            this.UpdatePawns(false);

            this.GameState = GameStateType.ThrowNormal;
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
            this.UpdatePawns(true);
        }

        private async void DoMovePawn(Player p)
        {
            Pawn pawn = p.Pawns[p.SelectedPawn];

            bool atHome = pawn.IsAtHome;

            pawn.Move(this.playground, p.StepsLeft);

            if(!atHome)
                await Task.Delay(p.StepsLeft * PawnConstants.DisplayDelay);

            p.StepsLeft = 0;
            this.GameState = GameStateType.ChangePlayerTurn;
        }

        private void DoThrowNormal()
        {
            this.UpdateControls(true, false, false, false, false);
            this.UpdatePawns(false);
        }

        private void DoThrowMama()
        {
            this.UpdateControls(false, true, false, false, false);
            this.UpdatePawns(false);
        }

        private void DoThrowCatapult()
        {
            this.UpdateControls(false, false, false, true, false);
            this.UpdatePawns(false);
        }

        private void DoThrowNine()
        {
            this.UpdateControls(false, false, true, false, false);
            this.UpdatePawns(true);
        }
    }
}
