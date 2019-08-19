using RunProject.RunImplementTraining1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Training1;



namespace RunProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, RunCase> menu = new Dictionary<string, RunCase>();
            menu.Add("T1Task1", new Task1RunImplement());
            menu.Add("T1Task2", new Task2RunImplement());
            menu.Add("T1Task3", new Task3RunImplement());
            menu.Add("T1Task4", new Task4RunImplement());
            menu.Add("T1Task5", new Task5RunImplement());
            menu.Add("T2Task1", new RunImplementTraining2.Task1RunImplement());
            menu.Add("T2Task2", new RunImplementTraining2.Task2RunImplement());
            menu.Add("T2Task3", new RunImplementTraining2.Task3RunImplement());
            menu.Add("T2Task4", new RunImplementTraining2.Task4RunImplement());
         

            bool exit = true;
            do
            {
                Console.WriteLine("If you want run Training1 Task1 write T1Task1 ");
                Console.WriteLine("If you want run Training1 Task2 write T1Task2 ");
                Console.WriteLine("If you want run Training1 Task3 write T1Task3 ");
                Console.WriteLine("If you want run Training1 Task4 write T1Task4 ");
                Console.WriteLine("If you want run Training1 Task5 write T1Task5 ");
                Console.WriteLine("If you want run Training2 Task1 write T2Task1 ");
                Console.WriteLine("If you want run Training2 Task2 write T2Task2 ");
                Console.WriteLine("If you want run Training2 Task3 write T2Task3 ");
                Console.WriteLine("If you want run Training2 Task4 write T2Task4 ");
                string key = Console.ReadLine();
              
                if (menu.ContainsKey(key))
                {
                    exit = menu[key].Run();
                }
                else
                {
                    exit = false;
                }
            } while (exit);
        }
    }
}
