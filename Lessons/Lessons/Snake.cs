using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction Direction)
        {
            pList = new List<Point>();
            for (int i = 0; i != lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                pList.Add(p);
            }
        }
    }
}
