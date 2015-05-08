using System;

namespace CSharpNewFeatures.Structs
{
    public struct Point
    {
        // 该特性在 Visual Studio 2015 RC 中已取消，將不会出现在最终版本中。
        // public Point() { X = 1; Y = 1; }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
