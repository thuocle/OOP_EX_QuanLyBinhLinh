using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class DonDatHang
    {
        private int _soluong;
        public int MaSoDon { get; set; }
        public DateTime NgayDat { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int SoLuong {
            get { return _soluong; }
            set
            {
                _soluong = value;
                ThanhTien = DonGia * SoLuong;
            }
        }
        public double ThanhTien 
        {
            get;
            set;
        }
        public string GhiChu { get; set; }

        public void InThongTin()
        {
            Console.WriteLine($"Don hang co ma so {MaSoDon} dat ngay {NgayDat.ToShortDateString()} co tong tien la {ThanhTien}");
        }

        public DonDatHang()
        {
            Console.WriteLine("Nhap ma so don: ");
            MaSoDon = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay dat: ");
            NgayDat = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten san pham: ");
            TenSanPham = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            DonGia = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ghi chu: ");
            GhiChu =Console.ReadLine();
        }

        public DonDatHang(int maSoDon, DateTime ngayDat, string tenSanPham, double donGia, int soLuong, string ghiChu)
        {
            MaSoDon = maSoDon;
            NgayDat = ngayDat;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
            GhiChu = ghiChu;
        }
    }
}
