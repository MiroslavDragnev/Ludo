using Ludo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models.Dices
{
    public class DiceMama : Dice
    {
        public DiceMama()
            : base(DiceConstants.MinMama, DiceConstants.MaxMama)
        {
        }
    }
}
