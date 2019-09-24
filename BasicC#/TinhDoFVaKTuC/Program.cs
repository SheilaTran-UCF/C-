using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDoFVaKTuC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do C: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do K tuong ung la = {0}", celsius + 273);
            Console.WriteLine("Do F tuong ung la = {0}", celsius * 18 / 10 + 32);
            Console.ReadKey();
        }
    }
}
