﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0,24,78,'+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();



            Point p = new Point(4,5,'*');
            p.Draw();


            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition( x, y);
            Console.Write( sym );
        }
    }
}
