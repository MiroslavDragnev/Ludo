using Ludo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models.Dices
{
    public class DiceCatapult : Dice
    {
        public DiceCatapult()
            : base(DiceConstants.MinCatapult, DiceConstants.MaxCatapult)
        {
        }
    }
}
