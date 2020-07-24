using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class HorisontalLine
    {
        List<Point> pList;
        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int i = xLeft; i != xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);

            }
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
