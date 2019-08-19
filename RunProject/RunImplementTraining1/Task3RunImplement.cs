using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Task3;

namespace RunProject.RunImplementTraining1
{
    public class Task3RunImplement : RunCase
    {
        public bool Run()
        {
            string exit;
            do
            {
                Console.WriteLine("******Circle Carcualator******");
                Console.WriteLine("~~~Write Circle radius~~");
                double radius = (Convert.ToDouble(Console.ReadLine()));
                Circle circle = new Circle();
                Console.WriteLine($"Area ==> {circle.GetArea(radius)}");
                Console.WriteLine($"Length ==> {circle.GetLength(radius)}");
                Console.WriteLine($"If You want exit type exit , If not type anything");
                exit = Console.ReadLine();
            } while (!exit.Equals("exit"));
            return true;
        }
    }
}
