using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
        public int x;
        public int y;
        public Char sym;

        public Point()//добавление коструктора
        {
            
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x=p.x;
            y=p.y;
            sym = p.sym;
        }

        public void Move(int offset, Deriction direction)//метод сдвигает точку на расстояние offstet по направлению direction
        {
            if (direction == Deriction.Right)
            {
                x = x+ offset;
            }

            if (direction == Deriction.Left)
            {
                x = x - offset;
            }
            else if (direction == Deriction.UP)
            {
                y = y + offset;
            }
            else if (direction == Deriction.DOWN)
            {
                y = y - offset;
            }
        }

        public void Draw()
        {

            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
