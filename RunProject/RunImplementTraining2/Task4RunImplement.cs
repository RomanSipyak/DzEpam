﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training2.Task4;

namespace RunProject.RunImplementTraining2
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
                    Console.WriteLine("******Trainig2 Task4******");
                    Console.WriteLine("Write x for rectangle");
                    int x = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Write y for rectangle");
                    int y = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Write x for square");
                    int x2 = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Write y for square");
                    int y2 = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Write x for figure");
                    int x3 = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Write y for figure");
                    int y3 = (Convert.ToInt32(Console.ReadLine()));

                    DrawAll(new Rectangle(x, y), new Square(x2, y2), new Figure(x3, y3));
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

        private void DrawAll(params IDrawable[] array)
        {
            foreach (IDrawable member in array)
            {
                member.Draw();
            }
        }
    }
}
