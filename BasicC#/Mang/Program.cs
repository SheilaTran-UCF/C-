using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mang");
            Console.WriteLine("-----------------------");
            int[] n = new int[10]; /* n la mot mang gom 10 so nguyen */
            int i, j;
            /* khoi tao cac phan tu cua mang n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* hien thi gia tri cac phan tu cua mang n */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Phan tu [{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();
        }
    }
}
