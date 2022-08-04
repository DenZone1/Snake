using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            #region Рамка поля игры

            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            upline.Drow();

            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Drow();

            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            leftLine.Drow();

            VerticalLine rigntLine = new VerticalLine(0, 24, 78, '+');
            rigntLine.Drow();
            #endregion

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Deriction.Right);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            
        }


    }
}

