using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class HorisontalLine : Figure
    {
        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int i = xLeft; i != xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);

            }
        }
    }
}
