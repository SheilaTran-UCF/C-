using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Ke_Thua
{
    class HinhChuNhat: Hinh    {
        public int tinhDienTich()
        {
            return (chieu_cao * chieu_rong);
        }
        public void Display()
        {
            Console.WriteLine("Chieu cao: {0}", chieu_cao);
            Console.WriteLine("Chieu rong: {0}", chieu_rong);
            Console.WriteLine("Dien tich: {0}", tinhDienTich());
        }
    }
}
