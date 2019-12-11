using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector vec1 = new MyVector(1.5f, 3.7f);
            MyVector vec2 = new MyVector(7.6f, 9.1f);

            Console.WriteLine($"vector 1 X: {vec1[0]}/{vec1.X}");
            Console.WriteLine($"vector 1 X: {vec1[1]}/{vec1.X}");
            Console.WriteLine($"vector 2 X: {vec2[0]}/{vec2.X}");
            Console.WriteLine($"vector 2 X: {vec2[1]}/{vec2.X}");

            vec1[0] = 666.666f;

            Console.WriteLine(vec1[0]);

            vec1["x"] = 27.5f;
            vec1["b"] = 50.5f;
            vec2["a"] = 60.5f;
            vec2["1"] = 50.5f;
        }
    }
}
