using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class hocsinhs
    {
        private double _diem;
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemToan { get; set; }
        public double DiemVan 
        {
            get;
            set;
        } 
        public double DiemAnh 
        {
            get => _diem;
            set
            {
                _diem = value;
                DiemTrungBinh = (DiemToan + DiemVan + DiemAnh)/3;
            }
        }
        public double DiemTrungBinh 
        {
            get; private set;
        }

        public hocsinhs()
        {
            Console.WriteLine("Nhap vao ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap lop: ");
            Lop = Console.ReadLine();
            Console.WriteLine("Nhap vao ngay sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Toan: ");
            DiemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Van: ");
            DiemVan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Anh: ");
            DiemAnh = double.Parse(Console.ReadLine());
        }

        public hocsinhs(string hoTen, string lop, DateTime ngaySinh, double diemToan, double diemVan, double diemAnh)
        {
            HoTen = hoTen;
            Lop = lop;
            NgaySinh = ngaySinh;
            DiemToan = diemToan;
            DiemVan = diemVan;
            DiemAnh = diemAnh;
        }
        public void InThongTin()
        {
            Console.WriteLine($"{HoTen} lop {Lop}, co diem trung binh la {DiemTrungBinh}");
            
        }
    }
}
