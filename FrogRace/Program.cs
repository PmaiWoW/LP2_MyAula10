using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        private static Random rnd;
        private static object threadLock = new object();

        static void Main(string[] args)
        {
            rnd = new Random();

            Thread frog1 = new Thread(FrogRace);
            Thread frog2 = new Thread(FrogRace);
            Thread frog3 = new Thread(FrogRace);
            frog1.Start(69);
            frog2.Start(420);
            frog3.Start(42069);
            frog1.Join(420);
            frog2.Join(420);
            frog3.Join(42069);
        }

        private static void FrogRace(object frogID)
        {
            int ID = (int)frogID;
            int jumpNum = 0;

            for (int i = 0; i < 10; i++)
            {
                int waitForMillis;
                lock (threadLock)
                {
                    waitForMillis = rnd.Next(1000);
                }
                Console.WriteLine($"Frog {ID} made jump number " +
                    $"{jumpNum + 1}!");
                jumpNum++;
                Thread.Sleep(waitForMillis);
            }
        }
    }
}
