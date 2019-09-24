using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    class Program
    {
        public int FindMax(int num1, int num2)
        {
            /* khai bao bien cuc bo */
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        public int TinhGiaiThua(int num)
        {
            /* khai bao bien cuc bo */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = TinhGiaiThua(num - 1) * num;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Goi phuong thuc trong C#");
            Console.WriteLine("--------------------------");
            /* phan dinh nghia bien cuc bo  */
            int a = 100;
            int b = 200;
            int ret;
            Program n = new Program();

            //goi phuong thuc FindMax
            ret = n.FindMax(a, b);
            Console.WriteLine("Gia tri lon nhat la: {0}", ret);
            Console.ReadLine();
            ////goi phuong thuc 
            //Console.WriteLine("6! = {0}", n.TinhGiaiThua(6));
            //Console.WriteLine("7! = {0}", n.TinhGiaiThua(7));
            //Console.WriteLine("8! = {0}", n.TinhGiaiThua(8));
            //Console.ReadLine();

            Console.ReadKey();
        }
    }
}
