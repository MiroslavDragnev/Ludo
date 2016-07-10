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
    }
}
