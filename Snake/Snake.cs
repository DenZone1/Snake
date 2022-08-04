﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        
        public Snake(Point tail, int lenght, Deriction direction)//передаем класс направлений
        {
            plist = new List<Point>();
            for (int i = 0; i < lenght; i++)
            { 
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            
            }
        }
    }
}
