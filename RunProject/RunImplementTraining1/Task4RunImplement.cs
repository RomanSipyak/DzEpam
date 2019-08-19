using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Task4;

namespace RunProject.RunImplementTraining1
{
    public class Task4RunImplement : RunCase
    {
        public bool Run()
        {
            string exit;
            do
            {
                try
                {
                    Console.WriteLine("******Rectange Carcualator******");
                    Console.WriteLine("~~~Write LeftTopXCorner~~");
                    Rectangle.LeftTopXCorner = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("~~~Write LeftTopYCorner~~");
                    Rectangle.LeftTopYCorner = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("~~~Write RightBottomXCorner~~");
                    Rectangle.RightBottomXCorner = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("~~~Write RightBottomYCorner~~");
                    Rectangle.RightBottomYCorner = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"Perimetr ==> {Rectangle.CalcPerimeter()}");
                    Console.WriteLine($"Area ==> {Rectangle.CalcArea()}");
                    ////////////////////////////////////////////////////
                    Console.WriteLine("******Circle Carcualator******");
                    Console.WriteLine("~~~Write Circle radius~~");
                    double radius = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine($"Area ==> {Circle.GetArea(radius)}");
                    Console.WriteLine($"Length ==> {Circle.GetLength(radius)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine($"If You want exit type exit , If not type anything");
                exit = Console.ReadLine();
            } while (!exit.Equals("exit"));
            return true;
        }
    }
}
