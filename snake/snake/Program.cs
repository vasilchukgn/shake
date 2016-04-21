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
            Console.CursorVisible = false;
            Console.SetBufferSize(120, 30);
            Console.SetWindowSize(120, 30);

            Walls walls = new Walls(120, 30);

            walls.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*', "Green");
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);         
            Snake snake = (Snake) fSnake;
            snake.Draw();
                
            FoodCreator foodCreator = new FoodCreator(120, 30, '$', "Red");
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.SetCursorPosition(54, 15);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("GAME OVER!!!");
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                System.Threading.Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }                                
            } 
            Console.ReadLine();
        } 
    } 
}
