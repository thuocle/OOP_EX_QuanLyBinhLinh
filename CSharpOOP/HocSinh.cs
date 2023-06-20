using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class HocSinh : Nguoi  //hoc sinh ke thua lop cha Nguoi(ke thua toan bo cac thuoc tinh, phuong thuc (khong phai private))
    {
        public string MaHS { get; set; }
        public double DiemTB { get; set; }
        public string MaLop { get; set; }

        public void NhapThongTinHS()
        {
            base.NhapThongTin();
            Console.Write("Nhap ma hoc sinh:");
            MaHS = Console.ReadLine();
            Console.Write("Nhap diem hoc sinh:");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap ma lop:");
            MaLop = Console.ReadLine();
        }

        public void HienThiThongTinHS(/*params*/)
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ma hoc sinh: {MaHS}\nDiem Tb: {DiemTB} \nMa lop: {MaLop}");
            Console.WriteLine("===========");
        }
    }
}
