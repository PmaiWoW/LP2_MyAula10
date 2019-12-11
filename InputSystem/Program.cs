using System;
using System.Threading;
using System.Collections.Concurrent;

namespace InputSystem
{
    class Program
    {
        private static BlockingCollection<ConsoleKey> input;
        static void Main(string[] args)
        {
            input = new BlockingCollection<ConsoleKey>();

            Thread producer = new Thread(ReadInput);
            Thread consumer = new Thread(DoStuff);

            producer.Start();
            consumer.Start();

            producer.Join();
            consumer.Join();

            Console.WriteLine("Nooooo, why would you do that!!!" +
                "\nNow we're going to the shadow real, jiiiiimbbb-");
        }

        private static void ReadInput()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                input.Add(key);
            } while (key != ConsoleKey.Escape);
        }

        private static void DoStuff()
        {
            ConsoleKey key;
            while((key = input.Take()) != ConsoleKey.Escape)
            {
                switch (key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("Cima");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Esquerda");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Baixo");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Direita");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
