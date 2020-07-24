using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lessons
{
    class Snake : Figure
    {
        Direction Direction;
        public Snake(Point tail, int lenght, Direction _Direction)
        {
            Direction = _Direction;
            pList = new List<Point>();
            for (int i = 0; i != lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

    }
}
