using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        public static void Main(string[] args)
        {
            Console.WriteLine("Enum trong C#");
            Console.WriteLine("------------------------\n");

            int dau_tuan = (int)Days.Mon;
            int cuoi_tuan = (int)Days.Fri;
            Console.WriteLine("Thu hai: {0}", dau_tuan);
            Console.WriteLine("Thu sau: {0}", cuoi_tuan);
            Console.ReadKey();

        }
    }
}
