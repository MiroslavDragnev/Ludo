using Ludo.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        public void GetResultFromWheel()
        {

            // Gets the number of the button from the wheel and does stuff through methods
             switch (spinResult)
             {
                 case WheelType.Bomb: // Placing a bomb on a field
                     {
                         // HandlePawnClick
                         break;
                     }
                 case WheelType.BigMama: //Big mama
                     {
                         //HandleDiceClick
                         //DiceEnabledChanged
                         break;
                     }
                 case WheelType.Catapult: // catapult
                     {
                         // HandlePawnClick
                         break;
                     }
                 case WheelType.Switch: //switch
                     {
                         //DisplayNewPawnPos
                         break;
                     }
                 case WheelType.Sleep: // sleep
                     {
                         // HandlePawnClick
                         break;
                     }
                 case WheelType.Miss: //miss
                     {
                         this.currentPlayer.IsSleeping = true;
                         break;
                     }
             }
         
        }
    }
}
