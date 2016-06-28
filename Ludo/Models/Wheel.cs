namespace Ludo.Models
{
    using System;
    using Ludo.Enumerations;

    public static class Wheel
    {
        //TODO
        private static Random generator = new Random();
        private static int number = generator.Next(0, 6);

        public static WheelType GetWheelType()
        {
            switch (number)
            {
                case 0:
                    return WheelType.BigMama;
                    break;
                case 1:
                    return WheelType.Switch;
                    break;
                case 2:
                    return WheelType.Miss;
                    break;
                case 3:
                    return WheelType.Bomb;
                    break;
                case 4:
                    return WheelType.Sleep;
                    break;
                case 5:
                    return WheelType.Catapult;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        public static void CheckWheelType(WheelType type)
        {
            //TODO: Check if it's not blank or without pawn
        //    if (type!=)
        //    {
                
        //    }
        }
    }
}
