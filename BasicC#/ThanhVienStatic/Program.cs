using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhVienStatic
{
    class Program
    {
        public static int num; //thanh vien static
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Thanh vien Static trong C#");
            Console.WriteLine("------------------------\n");

            //tao cac doi tuong ThanhVienStatic
            Program s1 = new Program();
            Program s2 = new Program();
            //goi phuong thuc count()
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("Gia tri bien num cho doi tuong s1 la: {0}", s1.getNum());
            Console.WriteLine("Gia tri bien num cho doi tuong s2 la: {0}", s2.getNum());

            Console.ReadKey();
        }
    }
}
