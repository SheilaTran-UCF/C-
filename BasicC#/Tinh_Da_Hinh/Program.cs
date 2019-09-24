using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Da_Hinh
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh da hinh trong C#");
            Console.WriteLine("Vi du minh hoa Da hinh dong");
            Console.WriteLine("--------------------------");

            HinhChuNhat r = new HinhChuNhat(10, 7);
            double a = r.tinhDienTich();
            Console.WriteLine("Dien tich: {0}", a);
            Console.ReadKey();
        }
    }
}
