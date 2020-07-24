using System;
using System.Collections.Generic;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorisontalLine Upline = new HorisontalLine(0, 78, 0, '%');
            Upline.Drow();

            VerticallLine LeftLine = new VerticallLine(0, 24, 0, '%');
            LeftLine.Drow();

            HorisontalLine DownLine = new HorisontalLine(0, 79, 24, '%');
            DownLine.Drow();

            VerticallLine RightLine = new VerticallLine(0, 24, 78, '%');
            RightLine.Drow();

            Console.ReadLine();

        }
    }
}

