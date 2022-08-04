using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);


            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

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

            Console.ReadLine();
        }


    }
}

