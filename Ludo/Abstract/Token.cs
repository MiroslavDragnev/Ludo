using Ludo.Contracts;
using Ludo.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ludo.Models;

namespace Ludo.Abstract
{
    public abstract class Token : IToken
    {
        public abstract void DoAction(Player player, Pawn pawn, Game game);
       
    }
}
