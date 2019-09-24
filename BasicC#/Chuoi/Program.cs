using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cac cach tao chuoi trong C#");
            Console.WriteLine("-------------------------------------");

            //su dung phep gan hang chuoi va toan tu noi chuoi
            string fname, lname;
            fname = "Tran Minh";
            lname = "Chinh";

            string fullname = fname + " " + lname;
            Console.WriteLine("Ho va ten: {0}", fullname);

            //su dung constructor cua lop string
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("\nLoi chao bang tieng Anh: {0}", greetings);

            //tu cac phuong thuc ma tra ve mot chuoi
            string[] sarray = { "VietJack", "xin", "chao", "cac", "ban" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("\nThong diep: {0}", message);

            //dinh dang phuong thuc de chuyen doi mot gia tri
            DateTime waiting = new DateTime(2016, 8, 1, 17, 58, 1);
            string chat = String.Format("Thong diep duoc gui luc {0:t} ngay {0:D}", waiting);
            Console.WriteLine("\nThong diep: {0}", chat);

            Console.ReadKey();
        }
    }
    //class SoSanhChuoi
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("So sanh chuoi trong C#");
    //        Console.WriteLine("-------------------------------------");

    //        string str1 = "So sanh chuoi trong C#";
    //        string str2 = "So sanh chuoi trong Csharp";

    //        if (String.Compare(str1, str2) == 0)
    //        {
    //            Console.WriteLine(str1 + " va " + str2 + " la giong nhau.");
    //        }
    //        else
    //        {
    //            Console.WriteLine(str1 + " va " + str2 + " la khong giong nhau.");
    //        }

    //        Console.ReadKey();
    //    }
    //}

    //class KiemTraChuoi
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Kiem tra chuoi con trong C#");
    //        Console.WriteLine("-------------------------------------");

    //        string str = "Chuoi con trong C#";
    //        if (str.Contains("trong"))
    //        {
    //            Console.WriteLine("Tim thay chuoi con 'trong'.");
    //        }

    //        Console.ReadKey();
    //    }
    //}

    //class ChuoiCon
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Lay chuoi con trong C#");
    //        Console.WriteLine("-------------------------------------");

    //        string str = "Lay chuoi con trong C#";
    //        Console.WriteLine("Chuoi ban dau: " + str);
    //        string substr = str.Substring(10);
    //        Console.WriteLine("Chuoi con: " + substr);

    //        Console.ReadKey();
    //    }
    //}

    //class CongChuoi
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Noi chuoi trong C#");
    //        Console.WriteLine("-------------------------------------");

    //        string[] starray = new string[]{"Hoc C# co ban va nang cao tai VietJack.",
    //         "Chuong nay trinh bay ve chuoi trong C#.",
    //         "Chung ta dang tim hieu ve noi chuoi trong C#.",
    //         "VietJack chuc cac ban hoc tot.",
    //         "Xin tran trong cam on!"};

    //        string str = String.Join("\n", starray);
    //        Console.WriteLine(str);

    //        Console.ReadKey();
    //    }
    //}

}
