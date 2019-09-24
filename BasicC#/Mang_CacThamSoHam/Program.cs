using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_CacThamSoHam
{
    class Program
    {
        class MangThamSo
        {
            public int CongPhanTu(params int[] arr)
            {
                int sum = 0;
                foreach (int i in arr)
                {
                    sum += i;
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mang tham so");
            Console.WriteLine("-------------------------------------");

            //tao doi tuong MangThamSo
            MangThamSo app = new MangThamSo();
            int sum = app.CongPhanTu(512, 720, 250, 567, 889);
            Console.WriteLine("Tong bang: {0}", sum);
            Console.ReadKey();
        }
    }
}
