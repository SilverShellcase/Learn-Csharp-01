using System;
using System.Diagnostics;
using System.Text;

namespace Learn_Csharp_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Week mon = Week.Monday;
            Console.WriteLine(mon);
            Person p1 = new Person();
            p1.Age = 22;
            p1.Name = "张三";
            Console.WriteLine(p1);
        }

        public static void Add(int num)
        {
            num += 10;
        }

        public static void Add(ref int num)
        {
            num += 10;
        }
    }
}