using System;

namespace CSharpDay3
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void show()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public static Point operator -(Point p)
        {
            p.x = - p.x;
            p.y = - p.y;
            return p;
        }
        
        public static Point operator +(Point p1, Point p2)
        {
            var point = new Point(0, 0);
            point.x = p1.x + p2.x;
            point.y = p1.y + p2.y;
            return point;
        }
    }
}