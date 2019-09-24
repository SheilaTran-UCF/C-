using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Dong_Goi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dong goi trong C#");
            Console.WriteLine("-------------------------------");

            //tao doi tuong Rectangle
            HinhChuNhat_Public r = new HinhChuNhat_Public();//Public
            //HinhChuNhat_Private r = new HinhChuNhat_Private();//Private
            //HinhChuNhat_Internal r = new HinhChuNhat_Internal();
            //thiet lap cac thuoc tinh
            r.length = 4.5;
            r.width = 3.5;
            //goi phuong thuc
            r.Display();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
