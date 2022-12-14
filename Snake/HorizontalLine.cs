using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine : Figure
    {
   
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,sym);
                plist.Add(p);
            }
            
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
