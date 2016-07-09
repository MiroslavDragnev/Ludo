using Ludo.Constants;
using Ludo.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models
{
    public static class Wheel
    {
        public static event EventHandler SpinResult = delegate { };

        public static async void Spin(Button b, Random rnd)
        {
            b.Name = "btnWheel1";

            for (int i = 100, rVal = rnd.Next(1, 6); i >= 0; i -= rVal)
            {
                rVal = rnd.Next(WheelConstants.WheelMin, WheelConstants.WheelMax + 1);

                switch (b.Name)
                {
                    case "btnWheel1":
                        {
                            b.BackgroundImage = global::Ludo.Properties.Resources.WheelBomb;
                            b.Name = "btnWheel2";
                            break;
                        }
                    case "btnWheel2":
                        {
                            b.BackgroundImage = global::Ludo.Properties.Resources.WheelMama;
                            b.Name = "btnWheel3";
                            break;

                        }
                    case "btnWheel3":
                        {
                            b.BackgroundImage = global::Ludo.Properties.Resources.WheelCatapult;
                            b.Name = "btnWheel4";
                            break;

                        }
                    case "btnWheel4":
                        {
                            b.BackgroundImage = global::Ludo.Properties.Resources.WheelSwitch;
                            b.Name = "btnWheel5";
                            break;

                        }
                    case "btnWheel5":
                        {
                            b.BackgroundImage = global::Ludo.Properties.Resources.WheelSleep;
                            b.Name = "btnWheel6";
                            break;
                        }
                    case "btnWheel6":
                        {
                            b.BackgroundImage = global::Ludo.Properties.Resources.WheelMiss;
                            b.Name = "btnWheel1";
                            break;

                        }
                } 
                await Task.Delay(100 - i);
            }

            SpinResult(null, EventArgs.Empty);
        }
    }
}
