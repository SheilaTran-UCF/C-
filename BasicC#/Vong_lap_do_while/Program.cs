using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vong_lap_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vong lap do...while");
            Console.WriteLine("-------------------------------");

            /* phan dinh nghia bien cuc bo  */
            int a = 10;

            /* su thuc thi vong lap do...while */
            do
            {
                Console.WriteLine("Gia tri cua a la: {0}", a);
               // a = a + 1;
                a++;
            }
            while (a < 20);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
