using System;
using System.Text;

namespace TOTAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ObjectBeer.ten = "Haniken";
            ObjectBeer.soluong = 12;
            ObjectBeer.giatien = 12000;

            ClassFunction fun = new ObjectBeer();
            Console.WriteLine(fun.ThongBao());
            Console.WriteLine("Số tiền phải trả là: "+ ObjectBeer.TongTien + " VND");
        }
    }
}
