using Ludo.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public delegate void GameStateChanged(object sender, EventArgs e);

    public partial class Game : Form
    {
        private void TriggerStateChange()
        {
            if (this.OnStateChanged != null)
            {
                this.OnStateChanged(this, EventArgs.Empty);
            }
        }

        public GameStateType GameState
        {
            get
            {
                return this.gameState;
            }
            set
            {
                this.gameState = value;
                this.TriggerStateChange();
            }
        }

        private void GameStateHub(object sender, EventArgs e)
        {
            switch(this.GameState)
            {
                case GameStateType.InitPlayerTurn:
                    {
                        this.DoInitPlayerTurn();
                        break;
                    }
                case GameStateType.ChangePlayerTurn:
                    {
                        this.DoChangePlayerTurn();
                        break;
                    }
                case GameStateType.MovePawn:
                    {
                        this.DoMovePawn(this.players[turn]);
                        break;
                    }
                case GameStateType.ThrowNormal:
                    {
                        this.DoThrowNormal();
                        break;
                    }
                case GameStateType.ThrowMama:
                    {
                        this.DoThrowMama();
                        break;
                    }
                case GameStateType.ThrowNine:
                    {
                        this.DoThrowNine();
                        break;
                    }
                case GameStateType.ThrowCatapult:
                    {
                        this.DoThrowCatapult();
                        break;
                    }
                case GameStateType.SelectPawn:
                    {
                        this.DoSelectPawn(this.players[turn]);
                        break;
                    }
                case GameStateType.RotateWheel:
                    {
                        //this state appears when a pawn is on the special field
                        this.DoRotateWheel();
                        break;
                    }
                case GameStateType.WheelPlaceBomb:
                    {
                        break;
                    }
                case GameStateType.WheelPlaceSleep:
                    {
                        break;
                    }
                case GameStateType.WheelPlaceCatapult:
                    {
                        break;
                    }
                case GameStateType.WheelSwitchPawns:
                    {
                        break;
                    }
                case GameStateType.WheelMissTurn:
                    {
                        break;
                    }
            }
        }
    }
}
