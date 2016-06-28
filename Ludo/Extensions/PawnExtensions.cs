using Ludo.Constants;
using Ludo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Extensions
{
    public static class PawnExtensions
    {
        public static void Move(this Pawn p, List<Field> playground, int steps)
        {
            if (p.IsAtHome)
            {
                p.IsAtHome = false;
                p.CurrentField = playground[p.PawnPos];

                return;
            }

            p.PawnPos += 1;

            if (p.PawnPos >= PlaygroundConstants.PlaygroundSize)
            {
                p.PawnPos = 0;
            }

            p.CurrentField = playground[p.PawnPos];
        }
    }
}
