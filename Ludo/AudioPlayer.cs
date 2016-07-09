namespace Ludo
{
    using System.Media;
    public static class AudioPlayer
    {
        public static SoundPlayer player = new SoundPlayer();
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
    }
}
