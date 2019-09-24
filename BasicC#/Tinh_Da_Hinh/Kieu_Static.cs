using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_Da_Hinh
{
    class Kieu_Static
    {
        void print(int i)
        {
            Console.WriteLine("In so nguyen: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("In so thuc: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("In chuoi: {0}", s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh da hinh trong C#");
            Console.WriteLine("--------------------------");
            //tao doi tuong TestCsharp
            Kieu_Static p = new Kieu_Static();

            // goi ham print()
            p.print(5);
            p.print(500.263);
            p.print("Tinh KE Thua kieu Static");
            Console.ReadKey();
        }
    }
}
