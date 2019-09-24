using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_DaChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mang da chieu");
            Console.WriteLine("-----------------------");
            /* mot mang hai chieu gom 5 hang va 2 cot*/
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            /* hien thi gia tri cac phan tu trong mang */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Phan tu a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
