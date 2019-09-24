using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hang so !!!");
            Console.WriteLine("-------------------");

            //khai bao hang so pi
            const double pi = 3.14;
            // khai bao bien ban kinh va cong thuc tinh dien tich
            double r=4;
            double dien_tich = pi * r * r;
            Console.WriteLine("\nBan kinh: {0}, Dien tich: {1}", r, dien_tich);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
