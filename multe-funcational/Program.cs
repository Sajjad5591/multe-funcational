using System;
using System.Collections.Generic;
using System.IO;

namespace consoleApplication3
{
    public class Program
    {
        void show(string a, int b)
        {
            Console.WriteLine("name is:"+a);
            Console.WriteLine("age is:" + b);
        }

        int sum(int a, int b)
        {
            return (a + b);
        }
        float flo(int a, int b)
        {
            return (b / a);
            Console.WriteLine(a+b);
        }float mul(int a, int b)
        {
            return (b * a);
            Console.WriteLine(a + b);
        }
        float sub(int a, int b)
        {
            return (b - a);
            Console.WriteLine(a + b);
        }
        float rem(int a, int b)
        {
            return (b % a);
            Console.WriteLine(a + b);
        }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("sum is" +obj.sum(22,31));
            Console.WriteLine(" multilpation is" + obj.mul(21,43));
            Console.WriteLine("subtraction is" +obj.sub(21,55));
            Console.WriteLine("devation is" +obj.flo(21,2));
            obj.show("Sajjad",22);
        }
    }
}