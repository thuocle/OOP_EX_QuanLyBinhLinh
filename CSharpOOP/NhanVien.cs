using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public string PhongBan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public NhanVien()
        {

        }

        public void InThongTin()
        {
            Console.WriteLine($"Nhan vien {HoVaTen} thuoc phong ban {PhongBan} co so dien thoai la {SoDienThoai}");
        }
    }
}
