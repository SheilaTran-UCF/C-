using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Ke_Thua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh ke thua!");
            Console.WriteLine("------------------------\n");

            //tao doi tuong HinhChuNhat
            HinhChuNhat hcn = new HinhChuNhat();

            hcn.setChieuRong(5);
            hcn.setChieuCao(7);

            // in dien tich cua doi tuong.
            Console.WriteLine("Dien tich hinh chu nhat: {0}", hcn.tinhDienTich());

            Console.ReadKey();
        }
    }
}
