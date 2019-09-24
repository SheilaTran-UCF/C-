using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_cac_vong_lap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Long vong lap ");
            Console.WriteLine("Tim so nguyen to trong C#");
            Console.WriteLine("-------------------------------");

            /* phan dinh nghia bien cuc bo  */
            int i, j;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // neu tim thay uoc so thi khong phai la so nguyen to
                if (j > (i / j))
                    Console.WriteLine("{0} la so nguyen to", i);
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
