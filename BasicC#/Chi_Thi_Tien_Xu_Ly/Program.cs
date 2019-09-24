#define DEBUG
#define VC_V10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chi_Thi_Tien_Xu_Ly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chi thi tien xu ly trong C#");
            Console.WriteLine("Vi du minh hoa chi thi tien xu ly #define");
            Console.WriteLine("------------------------------------------");

            #if (DEBUG && !VC_V10)
                        Console.WriteLine("DEBUG da duoc dinh nghia");
            #elif (!DEBUG && VC_V10)
                           Console.WriteLine("VC_V10 da duoc dinh nghia");
            #elif (DEBUG && VC_V10)
                           Console.WriteLine("DEBUG va VC_V10 da duoc dinh nghia");
            #else
                           Console.WriteLine("DEBUG va VC_V10 chua duoc dinh nghia");
            #endif
            Console.ReadKey();
        }
    }
}
