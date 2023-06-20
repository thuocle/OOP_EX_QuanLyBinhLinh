using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public bool LaSanPhamMoi { get; set; }

        public SanPham()
        {
        }

        public SanPham(int maSanPham, string tenSanPham, string loaiSanPham, bool laSanPhamMoi)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            LoaiSanPham = loaiSanPham;
            LaSanPhamMoi = laSanPhamMoi;
        }

        public void InThongTin()
        {
            Console.WriteLine($"San pham {TenSanPham} co ma san pham: {MaSanPham}, thuoc loai san pham {LoaiSanPham}, {LaSanPhamMoi} la san pham moi");
        }
    }
}
