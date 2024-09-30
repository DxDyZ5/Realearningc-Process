using System.Media;
using System;

namespace startingAgain
{
    class Program
    {

        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer BUM = new SoundPlayer("Shotgun Sound Effects.wav");
                BUM.Load();
                Console.WriteLine("SHOTGUN: ");
                while (true)
                {
                    for (int i = 1; i > 0; i--) //One shot per load. Start in 1, it becomes 0 in the second loop.
                    {
                        Console.WriteLine($"BUM!  " ); BUM.Play();
                        Console.WriteLine("Reloading...");
                        Thread.Sleep(2000);
                    }
                }
               
            }
        }

    }
}
