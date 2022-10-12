using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("1-MOK", 3, 18, "Иван");
            Worker wr = new Worker("1-МОК", 40, "Колян");
            st.WriteInfo();
            Console.WriteLine();
            wr.WriteInfo();
            Console.ReadKey();
        }
    }
}
