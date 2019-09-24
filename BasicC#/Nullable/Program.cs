using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable ");
            Console.WriteLine("-----------------------\n");
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // hien thi gia tri

            Console.WriteLine(" Gia tri Nullable kieu int: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine(" Gia tri Nullable kieu boolean: {0}", boolval);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
