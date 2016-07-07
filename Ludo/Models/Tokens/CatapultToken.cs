using Ludo.Abstract;
using Ludo.Enumerations;
using Ludo;
using Ludo.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models.Tokens
{
    public class CatapultToken : Token
    {
        public override void DoAction(Player player, Pawn pawn, Game.Game game)
        {
            game.GameState = GameStateType.ThrowCatapult;
            
        }
    }
}
