using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Long cac lenh if trong C#");
            Console.WriteLine("-------------------------------");

            //* dinh nghia bien cuc bo  */
            int a = 100;
            int b = 200;

            /* kiem tra dieu kien */
            if (a == 100)
            {
                /*  dieu kien la true, tiep tuc kiem tra: */
                if (b == 200)
                {
                    /* dieu kien la true thi in dong sau: */
                    Console.WriteLine("Gia tri cua a la 100 va b la 200");
                }
            }
            Console.WriteLine("Gia tri chinh xac cua a la: {0}", a);
            Console.WriteLine("Gia tri chinh xac cua b la : {0}", b);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
