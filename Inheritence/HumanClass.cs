using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Human : Animal
    {
        // two parameters for Human subclass
        public string? Name { get; set; }
        public int Age { get; set; }

        // constructor for creating human, parameters name and age
        public Human(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        // method printing out info about human
        public void HumanInfo()
        {
            Console.WriteLine("The human is called "+ Name);
            Console.WriteLine($"The human is {Age} years old.");
        }
    }
}
