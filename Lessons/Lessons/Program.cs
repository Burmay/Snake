using System;
using System.Collections.Generic;
using System.Threading;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorisontalLine Upline = new HorisontalLine(0, 78, 0, '+');
            VerticallLine LeftLine = new VerticallLine(0, 24, 0, '+');
            HorisontalLine DownLine = new HorisontalLine(0, 79, 24, '+');
            VerticallLine RightLine = new VerticallLine(0, 24, 78, '+');
            Upline.Drow();
            LeftLine.Drow();
            RightLine.Drow();
            DownLine.Drow();

            Point a = new Point(10, 10, '*');
            Snake snake = new Snake(a, 4, Direction.RIGHR);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();

        }
    }
}

