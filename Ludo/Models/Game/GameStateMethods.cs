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
            this.btnTurn.Text = this.players[turn].Name;
            this.btnTurn.BackColor = ColorConstants.Colors[(int)this.players[turn].Color];

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

        private void DoMovePawn(Player p)
        {
            Pawn pawn = p.Pawns[p.SelectedPawn];
            
            pawn.Move(this.playground, p.StepsLeft);
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
