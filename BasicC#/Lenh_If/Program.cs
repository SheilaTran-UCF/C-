using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenh_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenh if ");
            Console.WriteLine("-------------------------------");
            /* dinh nghia bien cuc bo  */
            int a = 15;
            /* kiem tra dieu kien */
            if (a < 20)
            {
                /* dieu kien la true : */
                Console.WriteLine("a nho hon 20");
            }
            Console.WriteLine("Gia tri cua a la: {0}", a);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
