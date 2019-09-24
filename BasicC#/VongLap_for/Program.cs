using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VongLap_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vong lap for");
            Console.WriteLine("-------------------------------");

            //su thuc thi vong lap for
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Gia tri cua a la: {0}", a);
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
