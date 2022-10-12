using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student : youngMan
    {
        string CollegeName { get; set; }
        int course { get; set; }

        public Student(string college, int curs, int age, string name)
        {
            this.CollegeName = college;
            this.course = curs;
            this.age = age;
            this.name = name;
        }

        public new virtual void WriteInfo()
        {
            Console.WriteLine("Студент " + name + " который учится в " + CollegeName + " на " + course + " курсе.");
        }
    }
}
