using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpKieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ep Kieu trong C#");
            Console.WriteLine("-------------------------------");

            double d = 1234.56;
            Console.WriteLine("Gia tri  i truoc khi ep kieu = " + d);

            int i;
            // Chuyen kieu du lieu double thanh kieu int.
            i = (int)d;
            Console.WriteLine("Gia tri cua i khi da ep kieu = " + i);
            Console.ReadKey();
        }
    }
}
