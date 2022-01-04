﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Point p1 = new Point(1,2,'*');
            p1.Draw();

            Point p2 = new Point()
            {
                x = 4,
                y= 5,
                c = '&'

            };

            Console.WriteLine();
            Square square1 = new Square(2,5,'*');

            square1.Draw();

            Stick stick1 = new Stick(6, 6, '*');

            stick1.Draw();

            Console.ReadLine();
        }

    }
}
