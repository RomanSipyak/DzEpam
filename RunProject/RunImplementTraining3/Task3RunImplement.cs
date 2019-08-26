using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RunProject.RunImplementTraining3
{
   public class Task3RunImplement : RunCase
    {
        private static readonly Random Randomize = new Random();
        private static readonly object SyncLock = new object();
        private List<string> strings;

        public bool Run()
        {
            string exit;
            do
            {
                Console.WriteLine("******Trainig3 Task3******");

                this.strings = new List<string>();
                for (int i = 0; i < 120; i++)
                {
                    this.strings.Add(this.RandomString(4));
                }

                Console.WriteLine($"Source list have = {strings.Count} elements");

                for (int i = 0; i < this.strings.Count;)
                {
                    if (this.strings[i][0].Equals('Z'))
                    {
                        Console.WriteLine($"remote { this.strings[i]}");
                        this.strings.RemoveAt(i);
                    }
                    else
                    {
                      i++;
                    }
                }

                for (int i = 0; i < this.strings.Count; i++)
                {
                    string unigue = this.strings[i];
                    for (int j = i + 1; j < this.strings.Count;)
                    {
                        if (this.strings[j].Equals(unigue))
                        {
                            Console.WriteLine($"remote string[{j}] =  { this.strings[j]} equal string[{i}] =  { this.strings[i]} ");
                            this.strings.RemoveAt(j);
                        }
                        else
                        {
                          j++;
                        }
                    }
                }

                for (int i = 0; i < this.strings.Count; i++)
                {
                    for (int j = i + 1; j < this.strings.Count; j++)
                    {
                        if (this.strings[j].CompareTo(this.strings[i]) > 0)
                        {
                            string swap = this.strings[i];
                            this.strings[i] = this.strings[j];
                            this.strings[j] = swap;
                        }
                    }
                }

                for (int i = 0; i < this.strings.Count; i++)
                {
                    Console.WriteLine(this.strings[i]);
                }

                Console.WriteLine($"Computed list have = { this.strings.Count} elements");

                string displayBreak = string.Empty;
                do
                {
                    try
                    {
                        Console.WriteLine($"Write number of page");
                        this.DisplayPage(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine($"If You want exit type break , If not type anything");
                        displayBreak = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        exit = "exit";
                        displayBreak = "break";
                    }
                }
                while (!displayBreak.Equals("break"));
                Console.WriteLine("*****************");
                Console.WriteLine($"If You want exit type exit , If not type anything");
                exit = Console.ReadLine();
            }
            while (!exit.Equals("exit"));
            return true;
        }

        private static int RandomNumber(int min, int max)
        {
            lock (SyncLock)
            { // synchronize
                return Randomize.Next(min, max);
            }
        }

        private string RandomString(int num_letters)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string word = string.Empty;
            Random rand = new Random();
            for (int j = 1; j <= num_letters; j++)
            {
                int letter_num = RandomNumber(0, letters.Length);
                word += letters[letter_num];
            }

            return word;
        }

        private void DisplayPage(int pageNumber)
        {
            int countofPages = this.strings.Count / 5;
            if (this.strings.Count % 5 != 0)
            {
                countofPages++;
            }

            if (pageNumber > countofPages)
            {
                Console.WriteLine("Write more little number");
            }
            else
            {
                if (pageNumber != countofPages)
                {
                    Console.WriteLine($"Page number {pageNumber}");
                    for (int i = pageNumber * 5 - 5; i < pageNumber * 5; i++)
                    {
                        Console.WriteLine(this.strings[i]);
                    }
                }
                else
                  if (pageNumber == countofPages)
                  {
                    if (this.strings.Count % 5 != 0)
                    {
                        Console.WriteLine($"Page number {pageNumber}");
                        for (int i = this.strings.Count - this.strings.Count % 5; i < this.strings.Count; i++)
                        {
                            Console.WriteLine(this.strings[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Page number {pageNumber}");
                        for (int i = pageNumber * 5 - 5; i < pageNumber * 5; i++)
                        {
                            Console.WriteLine(this.strings[i]);
                        }
                    }
                  }

                Console.WriteLine($"Page number {pageNumber}");
            }
        }
    }
}
