using Ludo.Constants;
using Ludo.Enumerations;
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

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        public async void GetResultFromWheel(object sender, EventArgs e)
        {
            //quick & dirty fix
            var res = int.Parse(this.btnWheel.Name[this.btnWheel.Name.Length - 1].ToString());

            res -= 1;

            if (res <= 0)
                res = WheelConstants.WheelMax;

            this.spinResult = (WheelType)res;//int.Parse(this.btnWheel.Name[this.btnWheel.Name.Length - 1].ToString());
            //this.spinResult = WheelType.Bomb;
            var resultImage = btnWheel.BackgroundImage;
            var flickerImage = global::Ludo.Properties.Resources.WheelFlicker;
            
            for(int i = 0; i < 6; i++)
            {
                if(i % 2 == 0)
                {
                    this.btnWheel.BackgroundImage = flickerImage;
                }
                else
                {
                    this.btnWheel.BackgroundImage = resultImage;
                }

                await Task.Delay(100);
            }

            this.btnWheel.Name = "btnWheel";
            //the update of the name happens on DoInitPlayerTurn now
            //so that we can see the result of the spin while it's still our turn
            //this.btnWheel.Name = "btnWheel";

            // Gets the number of the button from the wheel and does stuff through methods
            switch (spinResult)
            {
                case WheelType.Bomb: // Placing a bomb on a field
                    {
                        this.GameState = GameStateType.WheelPlaceBomb;
                        break;
                    }
                case WheelType.BigMama: //Big mama
                    {
                        this.GameState = GameStateType.ThrowMama;
                        break;
                    }
                case WheelType.Catapult: // catapult
                    {
                        this.GameState = GameStateType.WheelPlaceCatapult;
                        break;
                    }
                case WheelType.Switch: //switch
                    {
                        this.GameState = GameStateType.WheelSwitchPawns;
                        break;
                    }
                case WheelType.Sleep: // sleep
                    {
                        this.GameState = GameStateType.WheelPlaceSleep;
                        break;
                    }
                case WheelType.Miss: //miss
                    {
                        this.GameState = GameStateType.WheelMissTurn;
                        break;
                    }
            }

        }
    }
}
