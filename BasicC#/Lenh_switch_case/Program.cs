using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenh_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenh switch trong C#");
            Console.WriteLine("-------------------------------");

            /* phan dinh nghia bien cuc bo  */
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Xuat sac!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Gioi");
                    break;
                case 'D':
                    Console.WriteLine("Trung binh");
                    break;
                case 'F':
                    Console.WriteLine("Hoc lai");
                    break;
                default:
                    Console.WriteLine("Gia tri khong hop le");
                    break;
            }
            Console.WriteLine("Hoc luc cua ban la: {0}", grade);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
