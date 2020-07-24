using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class VerticallLine : Figure
    {
        public VerticallLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yUp; i != yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);

            }
        }
    }
}
