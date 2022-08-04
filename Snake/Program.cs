﻿using System;
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
			VerticalLine vl = new VerticalLine(0, 10, 5, '%');
			Draw(vl);

			Point p = new Point(4, 5, '*');
			Figure fSnake = new Snake(p, 4, Deriction.Right);
			Draw(fSnake);
			Snake snake = (Snake)fSnake;

			HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

			List<Figure> figures = new List<Figure>();
			figures.Add(fSnake);
			figures.Add(vl);
			figures.Add(hl);

			foreach (var f in figures)
			{
				f.Draw();
			}
		}

		static void Draw(Figure figure)
		{
			figure.Draw();
		}


	}
}

