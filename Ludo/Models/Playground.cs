using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ludo.Constants;
using Ludo.Enumerations;
using System.IO;

namespace Ludo.Models
{
    public static class Playground
    {
        private static IList<Field> playground;
        private static IList<Field> redFinish;
        private static IList<Field> greenFinish;
        private static IList<Field> yellowFinish;
        private static IList<Field> blueFinish;

        static Playground()
        {
            playground = new List<Field>(PlaygroundConstants.PlaygroundSize);
            redFinish = new List<Field>(PlaygroundConstants.FinishSize);
            greenFinish = new List<Field>(PlaygroundConstants.FinishSize);
            yellowFinish = new List<Field>(PlaygroundConstants.FinishSize);
            blueFinish = new List<Field>(PlaygroundConstants.FinishSize);

            //hardcoded AF
            //don't touch, it might break :)
            var dict = new Dictionary<int, string>()
            {
                { 0, "0 327 5" }, { 1, "0 327 38" }, { 2, "0 327 71" }, { 3, "1 327 105" },
                { 4, "0 327 138" }, { 5, "0 327 171" }, { 6, "0 294 171" }, { 7, "1 294 204" },
                { 8, "0 261 204" }, { 9, "0 227 204" }, { 10, "0 194 204" }, { 11, "1 161 204" },
                { 12, "0 128 204" }, { 13, "0 128 237" }, { 14, "0 128 271" }, { 15, "0 161 271" },
                { 16, "0 194 271" }, { 17, "1 227 271" }, { 18, "0 261 271" }, { 19, "0 294 271" },
                { 20, "0 294 304" }, { 21, "1 327 304" }, { 22, "0 327 337" }, { 23, "0 327 370" },
                { 24, "0 327 403" }, { 25, "1 327 437" }, { 26, "0 327 470" }, { 27, "0 360 470" },
                { 28, "0 393 470" }, { 29, "0 393 437" }, { 30, "0 393 404" }, { 31, "1 393 370" },
                { 32, "0 393 337" }, { 33, "0 393 304" }, { 34, "0 427 304" }, { 35, "1 426 271" },
                { 36, "0 459 271" }, { 37, "0 493 271" }, { 38, "0 526 271" }, { 39, "1 559 271" },
                { 40, "0 592 271" }, { 41, "0 592 237" }, { 42, "0 592 204" }, { 43, "0 559 204" },
                { 44, "0 526 204" }, { 45, "1 493 204" }, { 46, "0 460 204" }, { 47, "0 426 204" },
                { 48, "0 426 171" }, { 49, "1 393 171" }, { 50, "0 393 138" }, { 51, "0 393 104" },
                { 52, "0 393 71" }, { 53, "1 393 38" }, { 54, "0 393 5" }, { 55, "0 360 5" },

                //red finish
                { 56, "5 360 38" }, { 57, "5 360 71" }, { 58, "5 360 105" }, { 59, "5 360 138" }, { 60, "6 360 171" },
                //green finish
                { 61, "5 161 238" }, { 62, "5 194 238" }, { 63, "5 227 238" }, { 64, "5 261 238" }, { 65, "6 294 238" },
                //yellow finish
                { 66, "5 360 437" }, { 67, "5 360 404" }, { 68, "5 360 370" }, { 69, "5 360 337" }, { 70, "6 360 304" },
                //blue finish
                { 71, "5 559 238" }, { 72, "5 526 238" }, { 73, "5 493 238" }, { 74, "5 460 238" }, { 75, "6 426 238" },
            };

            int[] fParams = new int[3];

            for (int i = 0; i < dict.Count; i++)
            {
                fParams = dict[i].Split(' ').Select(int.Parse).ToArray();

                if (i >= 56 && i <= 60)
                {
                    redFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }
                else if(i >= 61 && i <= 65)
                {
                    greenFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }
                else if(i >= 66 && i <= 70)
                {
                    yellowFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }
                else if(i >= 71 && i <= 75)
                {
                    blueFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }
                else
                {
                    playground.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }
            }
        }
        
        public static IList<Field> GetPlayground()
        {
            return playground;
        }

        public static IList<Field> GetFinish(ColorType color)
        {
            switch(color)
            {
                case ColorType.Red:return redFinish;
                case ColorType.Green: return greenFinish;
                case ColorType.Yellow: return yellowFinish;
                case ColorType.Blue: return blueFinish;
            }

            return redFinish;
        }
    }
}
