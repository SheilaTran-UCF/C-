using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc_TruyenThamSoBoiOutput
{
    class Program
    {
        public void getValue(out int x)
        {
            int temp = 10;
            x = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Truyen tham so boi output ");
            Console.WriteLine("-------------------------------------");
            //tao doi tuong Program
            Program n = new Program();

            /* phan dinh nghia bien cuc bo  */
            int a = 100;

            Console.WriteLine("Truoc khi goi phuong thuc, gia tri cua a la: {0}", a);

            /* goi ham getValue() de lay gia tri */
            n.getValue(out a);

            Console.WriteLine("Sau khi goi phuong thuc, gia tri cua a la: {0}", a);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
