﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task3
{
    public class Square : Figure
    {
        public Square(int x, int y) : base(x, y)
        {
            Console.WriteLine("Square inherited Figure constuctor with parameters " +
                              $"X={x},Y={y}");
        }

        public override void Draw()
        {
            System.Console.WriteLine("Draw was override in class => Square");
        }
    }
}
