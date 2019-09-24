using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Da_Hinh
{
    class HinhChuNhat: Hinh
    {
        private int chieu_dai;
        private int chieu_rong;
        public HinhChuNhat(int a = 0, int b = 0)
        {
            chieu_dai = a;
            chieu_rong = b;
        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich hinh chu nhat:");
            return (chieu_rong * chieu_dai);
        }
    }
}
