using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc_TruyenThamSoBangGiaTri
{
    class Program
    {
        public void swap(int x, int y)
        {
            int temp; //bien tam

            temp = x; /* luu giu gia tri x vao bien tam*/
            x = y;    /* dat gia tri cua y vao x */
            y = temp; /* dat gia tri cua temp vao y */
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Truyen tham so boi gia tri trong C#");
            Console.WriteLine("Trao doi gia tri trong C#");
            Console.WriteLine("------------------------------------");
            //tao doi tuong Program
            Program n = new Program();
            /* phan dinh nghia bien cuc bo  */
            int a = 100;
            int b = 200;

            Console.WriteLine("Truoc khi trao doi, gia tri cua a la: {0}", a);
            Console.WriteLine("Truoc khi trao doi, gia tri cua b la: {0}", b);

            /* goi ham de trao doi gia tri */
            n.swap(a, b);

            Console.WriteLine("\nSau khi trao doi, gia tri cua a la: {0}", a);
            Console.WriteLine("Sau khi trao doi, gia tri cua b la: {0}", b);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
