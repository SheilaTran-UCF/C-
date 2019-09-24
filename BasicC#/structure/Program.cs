using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    struct Book
    {
        public string ten_sach;
        public string tac_gia;
        public string the_loai;
        public int ma_sach;
        public void nhapGiaTri(string t, string a, string s, int id)
        {
            ten_sach = t;
            tac_gia = a;
            the_loai = s;
            ma_sach = id;
        }
        public void display()
        {
            Console.WriteLine("Tieu de: {0}", ten_sach);
            Console.WriteLine("Tac gia: {0}", tac_gia);
            Console.WriteLine("The loai: {0}", the_loai);
            Console.WriteLine("Ma sach: {0}", ma_sach);
        }

    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct trong C#");
            Console.WriteLine("------------------------\n");
            Book Book1 = new Book();   /* Khai bao Book1 thuoc kieu cau truc Book */
            Book Book2 = new Book();   /* Khai bao Book2 thuoc kieu cau truc Book */

            /* thong tin Book1 */
            Book1.nhapGiaTri("English Grammer in Use",
            "Raymond Murphy", "Tieng Anh", 6495407);

            /* thong tin book2 */
            /* thong tin chi tiet ve Book2 */
            Book2.ten_sach = "Toan hoc cao cap";
            Book2.tac_gia = "Tran Van A";
            Book2.the_loai = "Toan hoc";
            Book2.ma_sach = 6495700;

            /* In thong tin Book1 */
            Console.WriteLine("In thong tin cua cuon sach 1:");
            Book1.display();

            /* In thong tin Book2 */
            Console.WriteLine("\nIn thong tin cua cuon sach 2:");
            Book2.display();

            Console.ReadKey();
        }
    }
}
