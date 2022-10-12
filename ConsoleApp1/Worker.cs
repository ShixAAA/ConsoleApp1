using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Worker : youngMan
    {
        string PlaceOfWork { get; set; }

        public Worker(string placeOfWork, int age, string name)
        {
            PlaceOfWork = placeOfWork;
            this.age = age;
            this.name = name;
        }

        public new virtual void WriteInfo()
        {
            Console.WriteLine("Рабочий " + name + " который работает в " + PlaceOfWork + ".");
        }
    }
}
