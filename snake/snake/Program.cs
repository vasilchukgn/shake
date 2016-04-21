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
            Console.SetWindowSize(120, 30);
            
            //Console.SetBufferSize(50, 25);
         
/*            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            
            p1.Draw();
            p2.Draw();
*/
//           Console.WriteLine(Console.BufferWidth);
//            Console.WriteLine(Console.BufferHeight);

            HorizontalLine topLine = new HorizontalLine(0, Console.BufferWidth - 1, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, Console.BufferWidth - 1, 28, '+');
            VerticalLine leftLine = new VerticalLine(0, 28, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 28, Console.BufferWidth - 1, '+');
            
            topLine.Draw();            
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Console.ReadLine();
        }
    }
}
