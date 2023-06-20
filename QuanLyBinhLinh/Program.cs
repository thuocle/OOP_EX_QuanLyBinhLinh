using System;

namespace QuanLyBinhLinh
{
    class Program
    {
        static void Main(string[] args)
        {
            BinhLinh a = new Linh();
            BinhLinh b = new CungThu();
            /*BinhLinh c = new KiemSi();
            BinhLinh d = new DauSi();*/
            a.InThongTin();
            b.InThongTin();
            a.ChienDau(b);
        }
    }
}
