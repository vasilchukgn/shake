﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public String color;

        public Point(int x, int y, char sym, String color)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            this.color = color;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            color = p.color;
        }
        
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            if (color == "Red")
                Console.ForegroundColor = ConsoleColor.Red;
            if (color == "Green")
                Console.ForegroundColor = ConsoleColor.Green;
            if (color == "White")
                Console.ForegroundColor = ConsoleColor.White;

            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += offset;
            }
            else if (direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if (direction == Direction.UP)
            {
                y -= offset;
            }
            else if (direction == Direction.DOWN)
            {
                y += offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
