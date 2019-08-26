using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training3
{
    public class  Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }

        public override string ToString()
        {
            string result = "";
            foreach (string item in PhoneNumbers)
            {
                result += $"Name => {Name},Age => {Age},phone =>{item}\n";
            }
            return result;
        }

    }
}
