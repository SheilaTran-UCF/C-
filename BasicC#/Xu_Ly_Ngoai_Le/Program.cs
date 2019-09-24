using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xu_Ly_Ngoai_Le
{
    class Program
    {
        int result;
        Program()
        {
            result = 0;
        }
        public void phepChia(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Bat Exception: {0}", e);
            }
            finally
            {
                Console.WriteLine("Ket qua: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du minh hoa Exception");
            Console.WriteLine("---------------------------------");

            Program d = new Program();
            d.phepChia(25, 0);
            Console.ReadKey();
        }
    }
}
