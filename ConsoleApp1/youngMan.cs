using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class youngMan
    {
        internal string name { get; set; }
        internal int age { get; set; }

        private youngMan(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        internal youngMan()
        { }

        public void WriteInfo()
        {
            Console.WriteLine("Молодой человек " + name + " которому " + age + " лет.");
        }
    }
}
