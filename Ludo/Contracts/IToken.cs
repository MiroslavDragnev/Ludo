using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Contracts
{
    interface IToken
    {
        void DoAction(Models.Player player, Models.Pawn pawn, Models.Game.Game game);
    }
}
