using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5, '@');
            p1.Draw();

            Point p2 = new Point(2, 1, '^');
            p2.Draw();

            Console.ReadLine();
        }
    }
}

