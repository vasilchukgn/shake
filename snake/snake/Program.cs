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

            p1.Draw();
            p2.Draw();

            Console.ReadLine();

            p1.Move(5, 5);
            p2.Move(10, 10);

            p1.Draw();
            p2.Draw();

            Console.ReadLine();
        }
    }
}