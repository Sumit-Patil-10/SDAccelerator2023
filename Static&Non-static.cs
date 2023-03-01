using System;
using System.Collections.Generic;
using System.Text;
namespace TestiClass
{
    class Program
    {
        public int calculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
        static void Main(string[] args)
        {
            Program x = new Program();
            int newval = x.calculation(12,12);
            Console.WriteLine(newval);
            Console.ReadKey();
        }
    }
}
