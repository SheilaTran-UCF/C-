using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_LopCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lop Array trong C#");
            Console.WriteLine("-------------------------------------");

            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            //in cac phan tu trong mang ban dau
            Console.Write("\nMang ban dau: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // dao chieu mang
            Array.Reverse(temp);
            Console.Write("\nMang dao chieu: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sap xep mang
            Array.Sort(list);
            Console.Write("\nMang da qua sap xep: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
