using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training2.Task1;

namespace RunProject.RunImplementTraining2
{
    public class Task1RunImplement : RunCase
    {
        public bool Run()
        {
            string exit;
            do
            {
                Console.WriteLine("******Trainig2 Task1******");
                new Rectangle().Draw();
                new Square().Draw();
                
                Console.WriteLine($"If You want exit type exit , If not type anything");
                exit = Console.ReadLine();
            } while (!exit.Equals("exit"));
            return true;
        }
    }
}
