using System;

namespace CSharpNewFeatures.Structs
{
    public struct Point
    {
        public Point() { X = 1; Y = 1; }

        public int X { get; set; }
        public int Y { get; set; }
    }

    public static class PointStructTests
    {
        static void Test()
        {
            var p1 = default(Point);
            // Console.WriteLine("(\{p1.X}, \{p1.Y}"); // (0, 0)       // Visual Studio 2015 Preview
            Console.WriteLine($"({p1.X}, {p1.Y}"); // (0, 0)       // Visual Studio 2015 CTP 5
            var p2 = new Point();
            // Console.WriteLine("(\{p2.X}, \{p2.Y}"); // (1, 1)       // Visual Studio 2015 Preview
            Console.WriteLine($"({p2.X}, {p2.Y}"); // (1, 1)       // Visual Studio 2015 CTP 5
        }
    }
}
