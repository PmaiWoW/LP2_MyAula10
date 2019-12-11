using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Frog {ID} made jump number " +
                    $"{jumpNum + 1}!");
                jumpNum++;
                Thread.Sleep(rnd.Next(1000));
            }
        }
    }
}
