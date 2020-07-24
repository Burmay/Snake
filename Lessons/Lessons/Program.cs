using System;
using System.Collections.Generic;

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

            Point p3 = new Point(7, 10, '!');
            p3.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
/*  Пример цикла вывода списка на экран
            foreach (Point i in pList)
            {
                Console.WriteLine(i);
            }

    int x = numlist[0] - задать переменной х значение в данной ячейке списка
    pList.RemoveAt(0) - удалить ячейку списка под номером 
*/

            Console.ReadLine();
        }
    }
}

