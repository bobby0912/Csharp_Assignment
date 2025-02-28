//using c__Assignment;

//**Interface Implementation Challenge**

//Define an interface `IPlayable` with a method `Play()`. Implement this interface in `MusicPlayer` and `VideoPlayer` classes with different implementations.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    interface IPlayable
    {
        void Play();
    }

    class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }

    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IPlayable musicPlayer = new MusicPlayer();
    //        musicPlayer.Play(); // Output: Playing music...

    //        IPlayable videoPlayer = new VideoPlayer();
    //        videoPlayer.Play(); // Output: Playing video...
    //    }
    //}
}
