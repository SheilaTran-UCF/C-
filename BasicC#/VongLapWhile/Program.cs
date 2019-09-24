using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VongLapWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vong lap while");
            Console.WriteLine("-------------------------------");

            /* phan dinh nghia bien cuc bo  */
            int a = 10;

            /* su thuc thi cua vong lap while */
            while (a < 20)
            {
                Console.WriteLine("Gia tri cua a la: {0}", a);
                a++;
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
