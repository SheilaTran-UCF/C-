using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenh_if_else_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenh if...else trong C#");
            Console.WriteLine("-------------------------------");

            /* bien cuc bo  */
            int a = 100;

            /* kiem tra dieu kien */
            if (a == 10)
            {
                /*  dieu kien la true thi in dong sau: */
                Console.WriteLine("Gia tri cua a la 10");
            }

            else if (a == 20)
            {
                /*  dieu kien cua else if nay la true */
                Console.WriteLine("Gia tri cua a la 20");
            }

            else if (a == 30)
            {
                /* dieu kien cua else if nay la true  */
                Console.WriteLine("Gia tri cua a la 30");
            }

            else
            {
                /* khong co dieu kien nao o tren la true */
                Console.WriteLine("Khong co dieu kien nao o tren la true");
            }
            Console.WriteLine("Gia tri chinh xac cua a la: {0}", a);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
