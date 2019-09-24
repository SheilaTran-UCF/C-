using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Dong_Goi
{
    class HinhChuNhat_Internal
    {
        //cac bien thanh vien
        internal double length;
        internal double width;

        //cac phuong thuc
        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", length);
            Console.WriteLine("Chieu rong: {0}", width);
            Console.WriteLine("Dien tich: {0}", GetArea());
        }
    }
}
