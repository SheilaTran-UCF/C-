using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_cac_lenh_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Long cac lenh switch");
            Console.WriteLine("-------------------------------");

            int a = 100;
            int b = 200;

            switch (a)
            {
                case 100:
                    Console.WriteLine("Dong nay thuoc lenh switch ben ngoai!");
                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("Dong nay thuoc lenh switch ben trong!");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Gia tri chinh xac cua a la: {0}", a);
            Console.WriteLine("Gia tri chinh xac cua b la: {0}", b);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
