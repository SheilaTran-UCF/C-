using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nap_Chong_Toan_Tu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nap chong toan tu trong C#");
            Console.WriteLine("Vi du minh hoa nap chong toan tu");
            Console.WriteLine("--------------------------");
            //tao cac doi tuong Box1, Box2 va Box3
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double the_tich = 0.0;

            // nhap thong tin Box1
            Box1.setChieuDai(6.0);
            Box1.setChieuRong(7.0);
            Box1.setChieuCao(5.0);

            // nhap thong tin Box2
            Box2.setChieuDai(12.0);
            Box2.setChieuRong(13.0);
            Box2.setChieuCao(10.0);

            // tinh va hien thi the tich Box1
            the_tich = Box1.tinhTheTich();
            Console.WriteLine("The tich cua Box1 la: {0}", the_tich);

            // tinh va hien thi the tich Box2
            the_tich = Box2.tinhTheTich();
            Console.WriteLine("The tich cua Box2 la: {0}", the_tich);

            // con hai doi tuong
            Box3 = Box1 + Box2;

            // tinh va hien thi the tich Box3
            the_tich = Box3.tinhTheTich();
            Console.WriteLine("The tich cua Box3 la: {0}", the_tich);

            Console.ReadKey();
        }
    }
}
