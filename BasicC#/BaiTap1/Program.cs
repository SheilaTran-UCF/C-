using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaiTap1
{
    class TamGiac
    {
        // cac bien thanh vien
        double length;
        double width;

        //phuong thuc
        public void Acceptdetails()
        {
            length = 3;
            width = 4;
        }
        //phuong thuc
        public double GetArea()
        {
            return length * width;
        }

        //phuong thuc
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", length);
            Console.WriteLine("Chieu rong: {0}", width);
            Console.WriteLine("Dien tich: {0}", GetArea());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh minh hoa tinh huong doi tuong");
            Console.WriteLine("--------------------------------------------------\n");
            //tao doi tuong Rectangle
            TamGiac tg = new TamGiac();
            //goi cac phuong thuc cua doi tuong nay
            tg.Acceptdetails();
            tg.Display();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
