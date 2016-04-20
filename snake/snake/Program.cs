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

            HorizontalLine hline = new HorizontalLine(5, 30, 8, '+');
            hline.Draw();

            VerticalLine vline = new VerticalLine(8, 20, 5, '+');
            vline.Draw();

            Console.ReadLine();
        }
    }
}
