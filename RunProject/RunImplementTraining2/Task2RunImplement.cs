﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training2.Task2;

namespace RunProject.RunImplementTraining2
{
    public class Task2RunImplement : RunCase
    {
        public bool Run()
        {
            string exit;
            do
            {
                try
                {
                    Console.WriteLine("******Trainig2 Task2******");
                    Console.WriteLine("Write x for rectangle");
                    int x = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Write y for rectangle");
                    int y = (Convert.ToInt32(Console.ReadLine()));
                    new Rectangle(x, y).Draw();
                    Console.WriteLine("Write x for square");
                    int x2 = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Write y for square");
                    int y2 = (Convert.ToInt32(Console.ReadLine()));
                    new Square(x2, y2).Draw();

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
