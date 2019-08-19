using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2.Task3
{
    public class Figure
    {
        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public virtual void Draw()
        {
            System.Console.WriteLine("Draw was virtual in class => Figure");
        }
    }
}
