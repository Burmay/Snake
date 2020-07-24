using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class VerticallLine
    {
        List<Point> pList;
        public VerticallLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yUp; i != yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);

            }
        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
