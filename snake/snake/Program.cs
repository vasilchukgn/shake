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

            // Отрисовка рамки
            HorizontalLine topLine = new HorizontalLine(0, Console.BufferWidth - 1, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, Console.BufferWidth - 1, 28, '+');
            VerticalLine leftLine = new VerticalLine(0, 28, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 28, Console.BufferWidth - 1, '+');
            
            topLine.Draw();            
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
