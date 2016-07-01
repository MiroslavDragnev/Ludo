using Ludo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models.Dices
{
    public class DiceNine : Dice
    {
        public DiceNine()
            : base(DiceConstants.MinNine, DiceConstants.MaxNine)
        {
        }
    }
}
