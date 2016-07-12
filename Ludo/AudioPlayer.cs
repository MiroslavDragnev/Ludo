namespace Ludo
{
    using System;
    using System.Media;
    public static class AudioPlayer
    {
        public static SoundPlayer player = new SoundPlayer();
        private static Random random = new Random();
        public static void PlayClickSound()
        {
            //player.SoundLocation = @"../../Sounds/Click.wav";
            player.Stream = Ludo.Properties.Resources.Click;
            player.Play();
        }
        public static void PlayHoverSound()
        {
            //player.SoundLocation = @"../../Sounds/Hover.wav";
            player.Stream = Ludo.Properties.Resources.Hover;
            player.Play();
        }
        public static void PlayLaughSound()
        {
            int rnd = random.Next(1, 6);

            switch (rnd)
            {
                case 1:
                    //player.SoundLocation = @"../../Sounds/Laugh1.wav";
                    player.Stream = Ludo.Properties.Resources.Laugh1;
                    break;
                case 2:
                    //player.SoundLocation = @"../../Sounds/Laugh2.wav";
                    player.Stream = Ludo.Properties.Resources.Laugh2;
                    break;
                case 3:
                    //player.SoundLocation = @"../../Sounds/Laugh3.wav";
                    player.Stream = Ludo.Properties.Resources.Laugh3;
                    break;
                case 4:
                    //player.SoundLocation = @"../../Sounds/Laugh4.wav";
                    player.Stream = Ludo.Properties.Resources.Laugh4;
                    break;
                case 5:
                    //player.SoundLocation = @"../../Sounds/Laugh5.wav";
                    player.Stream = Ludo.Properties.Resources.Laugh5;
                    break;
                default:
                    break;
            }
            player.Play();
        }
        public static void PlayWheelSound()
        {
            //player.SoundLocation = @"../../Sounds/WheelClick.wav";
            player.Stream = Ludo.Properties.Resources.WheelClick;
            player.Play();
        }
        public static void PlayTurnOnWheelSound()
        {
            player.Stream = Properties.Resources.TurnOn;
            player.Play();
        }
        public static void PlayCheckSound()
        {
            player.SoundLocation = @"../../Sounds/Check.wav";
            player.Stream = Ludo.Properties.Resources.Check;
            player.Play();
        }
        public static void PlayStartGameSound()
        {
            //player.SoundLocation = @"../../Sounds/StartGame.wav";
            player.Stream = Ludo.Properties.Resources.StartGame;
            player.Play();
        }
        public static void PlaceBombSound()
        {
            //player.SoundLocation = @"../../Sounds/PlaceBomb.wav";
            player.Stream = Ludo.Properties.Resources.PlaceBomb;
            player.Play();
        }
        public static void PlacePillowSound()
        {
            //player.SoundLocation = @"../../Sounds/PlacePillow.wav";
            player.Stream = Ludo.Properties.Resources.PlacePillow;
            player.Play();
        }
        public static void PlaceCatapultSound()
        {
            //player.SoundLocation = @"../../Sounds/PlaceCatapult.wav";
            player.Stream = Ludo.Properties.Resources.PlaceCatapult;
            player.Play();
        }
        public static void PlaySnoreSound()
        {
            player.Stream = Ludo.Properties.Resources.Snore;
            player.Play();
        }
        public static void PlayExplodeSound()
        {
            player.Stream = Ludo.Properties.Resources.Explode;
            player.Play();
        }
        public static void PlayMilitarySound()
        {            
            player.Stream = Ludo.Properties.Resources.Military;
            player.Play();
        }
        public static void PlayYeahSound()
        {
            player.Stream = Ludo.Properties.Resources.Yeah;
            player.Play();
        }
        public static void PlayCatapultEjectSound()
        {
            player.Stream = Ludo.Properties.Resources.CatapultEject;
            player.Play();
        }
        public static void PlaySleepSound()
        {
            player.Stream = Ludo.Properties.Resources.Sleep;
            player.Play();
        }
        public static void PlaySwitchSound()
        {
            player.Stream = Ludo.Properties.Resources.Switch;
            player.Play();
        }
        public static void PlayCatapultSound()
        {
            player.Stream = Ludo.Properties.Resources.Catapult1;
            player.Play();
        }
        public static void PlayMissSound()
        {
            player.Stream = Ludo.Properties.Resources.PowerDown;
            player.Play();
        }
        public static void PlayCatapultLoadSound()
        {
            player.Stream = Ludo.Properties.Resources.CatapultLoad;
            player.Play();
        }
        public static void PlayaPawnClickSound()
        {
            player.Stream = Ludo.Properties.Resources.PawnClick;
            player.Play();
        }

        public static void PlayStepSound()
        {
            int rnd = random.Next(1, 9);

            switch (rnd)
            {
                case 1:
                    player.Stream = Ludo.Properties.Resources.Step1;
                    break;
                case 2:
                    player.Stream = Ludo.Properties.Resources.Step2;
                    break;
                case 3:
                    player.Stream = Ludo.Properties.Resources.Step3;
                    break;
                case 4:
                    player.Stream = Ludo.Properties.Resources.Step4;
                    break;
                case 5:
                    player.Stream = Ludo.Properties.Resources.Step5;
                    break;
                case 6:
                    player.Stream = Ludo.Properties.Resources.Step6;
                    break;
                case 7:
                    player.Stream = Ludo.Properties.Resources.Step7;
                    break;
                case 8:
                    player.Stream = Ludo.Properties.Resources.Step8wav;
                    break;
                default:
                    break;
            }
            player.Play();
        }
        public static void PlayaEvilLaughSound()
        {
            player.Stream = Ludo.Properties.Resources.EvilLaugh;
            player.Play();
        }
    }
}
