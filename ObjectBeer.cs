using System;
using System.Collections.Generic;
using System.Text;

namespace TOTAL
{
    public class ObjectBeer : ClassFunction
    {
        public static string ten { get; set; }
        public static float soluong { get; set; }
        public static float giatien { get; set; }

        public static string thongbao;
        /*public float tongtien = ClassFunction.TinhTien(soluong, giatien);*/
        private static float tongtien;

        public static float TongTien
        {
            get { return ClassFunction.TinhTien(soluong, giatien); }
            set { tongtien = value; }
        }

        public override string ThongBao()
        {
            return thongbao = "Bạn đã mua Bia "+ten+" với số lượng "+soluong+" lon";
        }


    }
}
