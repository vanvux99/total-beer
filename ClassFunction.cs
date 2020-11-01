using System;
using System.Collections.Generic;
using System.Text;

namespace TOTAL
{
    public abstract class ClassFunction
    {
        public ClassFunction()
        { 
        }
        public static float TinhTien(float soluong, float giatien)
        {
            return soluong * giatien;
        }

        public abstract string ThongBao();
        
    }
}
