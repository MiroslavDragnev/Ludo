using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Enumerations
{
    public enum GameStateType
    {
        ThrowNormal,
        ThrowMama,
        ThrowNine,
        ThrowCatapult,
        SelectPawn,
        MovePawn,
        RotateWheel,
        WheelPlaceBomb,
        WheelPlaceSleep,
        WheelPlaceCatapult,
        WheelSwitchPawns,
        InitPlayerTurn,
        ChangePlayerTurn,
        //more to come
    }
}
