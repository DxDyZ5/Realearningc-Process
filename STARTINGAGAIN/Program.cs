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
                SoundPlayer player = new SoundPlayer("Shotgun Sound Effects.wav");
                player.Load();
                Console.WriteLine("SHOTGUN: ");
                while (true)
                {
                    for (int i = 1; i > 0; i--)
                    {
                        Console.WriteLine($"AMMO:{i} BUM!  " ); player.Play();
                        Console.WriteLine("Reloading...");
                        Thread.Sleep(1000);
                    }
                }
               
            }
        }

    }
}
