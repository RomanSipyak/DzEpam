using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training1.Task5;

namespace RunProject.RunImplementTraining1
{
    public class Task5RunImplement : RunCase
    {
        public bool Run()
        {
            string exit;
            do
            {
                try
                {
                    Console.WriteLine("******Complex Carcualator******");
                    Console.WriteLine("~~~Write real part of number1~~");
                    int real1 = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("~~~Write imaginary part of number1~~");
                    int imaginary1 = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("~~~Write real part of number2~~");
                    int real2 = (Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("~~~Write imaginary part of number2~~");
                    int imaginary2 = (Convert.ToInt32(Console.ReadLine()));

                    ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
                    ComplexNumber number2 = new ComplexNumber(real2, imaginary2);

                    Console.WriteLine($"Equal ==> {number1.Equals(number2)}");
                    Console.WriteLine($"Sum ==> {number1 + number2}");
                    Console.WriteLine($"Sub ==> {number1 - number2}");
                    Console.WriteLine($"Div ==> {number1 / number2}");
                    Console.WriteLine($"mul ==> {number1 * number2}");
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
