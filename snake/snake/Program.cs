using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(8, 3, '*');
            Point p4 = new Point(10, 5, '#');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            p1.Draw();
            p2.Draw();
            p3.Draw();
            p4.Draw();

            Console.ReadLine();

            p1.Move(5, 5);
            p2.Move(10, 10);
            p3.Move(5, 5);
            p4.Move(10, 10);


            p1.Draw();
            p2.Draw();
            p3.Draw();
            p4.Draw();
            
            Console.ReadLine();
        }
    }
}
