﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Task1;

namespace RunProject.RunImplementTraining1
{
    public class Task1RunImplement : RunCase
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
                    double leftTopXCorner = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("~~~Write LeftTopYCorner~~");
                    double leftTopYCorner = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("~~~Write RightBottomXCorner~~");
                    double rightBottomXCorner = (Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("~~~Write RightBottomYCorner~~");
                    double rightBottomYCorner = (Convert.ToDouble(Console.ReadLine()));

                    Rectangle simpleRectangle = new Rectangle(
                                                    leftTopXCorner,
                                                    leftTopYCorner,
                                                    rightBottomXCorner,
                                                    rightBottomYCorner);
                    Console.WriteLine($"Perimetr ==> {simpleRectangle.CalcPerimeter()}");
                    Console.WriteLine($"Area ==> {simpleRectangle.CalcArea()}");

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
