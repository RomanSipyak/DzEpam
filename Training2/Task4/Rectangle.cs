using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task4
{
   public class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x, y)
        {
            Console.WriteLine("Rectangle inherited Figure constuctor with parameters " +
                              $"X={x},Y={y}");
        }

        public override void Draw()
        {
            System.Console.WriteLine("Draw was override in class => Rectangle");
        }
    }
}
