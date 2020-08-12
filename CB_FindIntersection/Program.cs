using System;

namespace CB_FindIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Intersection();
            Console.WriteLine(a.FindIntersection(new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }));
            Console.ReadKey();
        }
    }
}
