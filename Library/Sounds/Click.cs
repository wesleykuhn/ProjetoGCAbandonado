using System.Media;

namespace GC.Library.Sounds
{
    internal static class Click
    {
        internal static void Play()
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.sound_click);
            sp.Play();
        }
    }
}
