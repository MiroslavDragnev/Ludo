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
            player.SoundLocation = @"../../Sounds/Click.wav";
            player.Play();
        }
        public static void PlayHoverSound()
        {
            player.SoundLocation = @"../../Sounds/Hover.wav";
            player.Play();
        }
        public static void PlayLaughSound()
        {
            int rnd = random.Next(1, 6);

            switch (rnd)
            {
                case 1:
                    player.SoundLocation = @"../../Sounds/Laugh1.wav";
                    break;
                case 2:
                    player.SoundLocation = @"../../Sounds/Laugh2.wav";
                    break;
                case 3:
                    player.SoundLocation = @"../../Sounds/Laugh3.wav";
                    break;
                case 4:
                    player.SoundLocation = @"../../Sounds/Laugh4.wav";
                    break;
                case 5:
                    player.SoundLocation = @"../../Sounds/Laugh5.wav";
                    break;
                default:
                    break;
            }
            player.Play();
        }
        public static void PlayWheelSound()
        {
            player.SoundLocation = @"../../Sounds/WheelClick.wav";
            player.Play();
        }
        public static void PlayCheckSound()
        {
            player.SoundLocation = @"../../Sounds/Check.wav";
            player.Play();
        }
        public static void PlayStartGameSound()
        {
            player.SoundLocation = @"../../Sounds/StartGame.wav";
            player.Play();
        }
    }
}
