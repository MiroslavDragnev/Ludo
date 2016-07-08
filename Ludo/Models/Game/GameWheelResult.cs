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
             switch ((int)spinResult)
             {
                 case 1: // Placing a bomb on a field
                     {
                         // HandlePawnClick
                         break;
                     }
                 case 2: //Big mama
                     {
                         //HandleDiceClick
                         //DiceEnabledChanged
                         break;
                     }
                 case 3: // catapult
                     {
                         // HandlePawnClick
                         break;
                     }
                 case 4: //switch
                     {
                         //DisplayNewPawnPos
                         break;
                     }
                 case 5: // sleep
                     {
                         // HandlePawnClick
                         break;
                     }
                 case 6: //miss
                     {
                         this.currentPlayer.IsSleeping = true;
                         break;
                     }
             }
         
        }
    }
}
