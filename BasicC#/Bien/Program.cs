using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khai bao va khoi tao bien !");
            Console.WriteLine("----------------------------------");

            //khai bao bien
            Int16 a;
            int b;
            double c;

            /* khoi tao bien */
            a = 1;
            b = 2;
            c = a + b;
            Console.WriteLine("Gia tri lan luoc a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
