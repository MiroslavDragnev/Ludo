using Ludo.Abstract;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models.Tokens
{
    public class BombToken : Token
    {
        public override void DoAction(Player player, Pawn pawn)
        {
            pawn.CurrentField = player.Home.FindEmptyHomeField();
        }
    }
    
}
