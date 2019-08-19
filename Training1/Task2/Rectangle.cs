using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1;

namespace Training1.Task2
{
    public class Rectangle
    {
        public Rectangle(double leftTopXCorner, double leftTopYCorner, double rightBottomXCorner, double rightBottomYCorner)
        {
            this.LeftTopXCorner = leftTopXCorner;
            this.LeftTopYCorner = leftTopYCorner;
            this.RightBottomXCorner = rightBottomXCorner;
            this.RightBottomYCorner = rightBottomYCorner;
        }

        public double LeftTopXCorner { get; set; }

        public double LeftTopYCorner { get; set; }

        public double RightBottomXCorner { get; set; }

        public double RightBottomYCorner { get; set; }

        public double TopSide
        {
            get
            {
                return MyMath.GetRoot(MyMath.GetPow((this.RightBottomXCorner - this.LeftTopXCorner), 2) + MyMath.GetPow((this.LeftTopYCorner - this.LeftTopYCorner), 2));
            }
        }

        public double CalcArea
        {
            get
            {
                return this.TopSide * this.RightSide;
            }
        }

        public double CalcPerimeter
        {
            get
            {
                return (this.TopSide + this.RightSide) * 2;
            }
        }

        private double RightSide
        {
            get
            {
                return MyMath.GetRoot(MyMath.GetPow((this.RightBottomXCorner - this.RightBottomXCorner), 2) + MyMath.GetPow((this.LeftTopYCorner - this.RightBottomYCorner), 2));
            }
        }
    }
}
