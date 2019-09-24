using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nap_Chong_Toan_Tu
{
   
        class Box
        {
            private double chieu_dai;
            private double chieu_rong;
            private double chieu_cao;

            public double tinhTheTich()
            {
                return chieu_dai * chieu_rong * chieu_cao;
            }

            public void setChieuDai(double len)
            {
                chieu_dai = len;
            }

            public void setChieuRong(double bre)
            {
                chieu_rong = bre;
            }

            public void setChieuCao(double hei)
            {
                chieu_cao = hei;
            }

            // nap chong toan tu + de cong hai doi tuong Box.
            public static Box operator +(Box b, Box c)
            {
                Box box = new Box();
                box.chieu_dai = b.chieu_dai + c.chieu_dai;
                box.chieu_rong = b.chieu_rong + c.chieu_rong;
                box.chieu_cao = b.chieu_cao + c.chieu_cao;
                return box;
            }
        }
    
}
