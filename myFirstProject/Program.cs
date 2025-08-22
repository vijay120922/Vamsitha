using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.Write($"{a},{b}");
            for (int i = 0; i < n; i++)
            {
                int c = a + b;
                Console.Write(","+c);
                a = b;
                b=c;
            }
            Console.WriteLine();

        }
    }
}
