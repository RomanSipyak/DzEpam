using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task1
{
    public class Square : Figure
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw was override in class => Square");
        }
    }
}
