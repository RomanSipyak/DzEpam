using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training3;

namespace RunProject.RunImplementTraining3
{
    class Task1RunImplement : RunCase
    {
        public bool Run()
        {
            string exit;
            do
            {
                Console.WriteLine("******Trainig3 Task1******");

                List<Person> persons = new List<Person>();
                for (int i = 0; i < 7; i++)
                {
                    persons.Add(RandomPerson());
                }
                
                persons.ForEach(p =>
                {
                    Console.WriteLine($"Person № => {persons.IndexOf(p)}");
                    Console.WriteLine(p);
                });

                //Task2
                persons.AddRange(new List<Person> { RandomPerson(), RandomPerson() });

                persons.ForEach(p =>
                {
                    Console.WriteLine($"Person № => {persons.IndexOf(p)}");
                    Console.WriteLine(p);
                });

                Console.WriteLine($"If You want exit type exit , If not type anything");
                exit = Console.ReadLine();
            } while (!exit.Equals("exit"));
            return true;
        }

        public string RandomNumber()
        {
            Random rnd = new Random();
            string phone = "+38096";
            for (int i = 0; i < 7; i++)
            {
                phone += RandomNumber(1, 10);
            }
            return phone;
        }

        public Person RandomPerson()
        {
            Person person = new Person();
            person.Name = RandomString(7);
            person.Age = RandomNumber(1, 101);
            person.PhoneNumbers = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                var list = person.PhoneNumbers.ToList<string>();
                list.Add(RandomNumber());
                person.PhoneNumbers = list;
            }
           
            return person;
        }

        public string RandomString(int num_letters)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            string word = "";
            Random rand = new Random();
            for (int j = 1; j <= num_letters; j++)
            {
                int letter_num = RandomNumber(0, letters.Length);
                word += letters[letter_num];
            }
            return word;
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}
