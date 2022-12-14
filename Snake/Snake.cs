using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        Deriction direction;

        public Snake(Point tail, int lenght, Deriction _direction)//передаем класс направлений
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }

        internal void Move()
{
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i]))
                    return true;
            }
            return false;
        }


        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Deriction.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Deriction.Right;
            else if (key == ConsoleKey.DownArrow)
                direction = Deriction.DOWN ;
            else if (key == ConsoleKey.UpArrow)
                direction = Deriction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
