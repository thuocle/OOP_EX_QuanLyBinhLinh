using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class HocVien
    {
        private double _hocPhi;
        private string _hoTen;
        public int MaHocVien { get; set; }
        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                _hoTen = value;
                Email = value.Trim().ToLower().Replace(" ", "") + "@edusolution.com";
                string[] hoTenArr = HoTen.Split(' ');
                Ho = hoTenArr.First();
            }
        }
        public DateTime NgaySinh { get; set; }
        public string Ho { get; private set; }
        public double HocPhi 
        {
            get { return _hocPhi; }
            set
            {
                if(value > 3000000)
                {
                    _hocPhi = value - (value * 0.5);
                }
                else
                {
                    _hocPhi = value;
                }
            }
        }
        public string Email { get; private set; }
        public string ThongTin(HocVien hv)
        {
            string result = hv.MaHocVien + " co ten la " + hv.HoTen + " co email la " + hv.Email;
            return result;
        }
        public void InThongTin(HocVien hv)
        {
            Console.WriteLine(ThongTin(hv));
        }
        public void TimKiemHocVien(List<HocVien> ds)
        {
            Console.WriteLine("Nhap ten hoc vien can tim");
            string s = Console.ReadLine();
            foreach (var item in ds)
            {
                if (item.HoTen.Contains(s))
                {
                    InThongTin(item);
                }
            }
        }

        public HocVien()
        {
            Console.WriteLine("Nhap ma hoc vien");
            MaHocVien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten hoc vien");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh hoc vien");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap hoc phi");
            HocPhi = int.Parse(Console.ReadLine());
        }

        public HocVien(int maHocVien, string hoTen, DateTime ngaySinh, double hocPhi)
        {
            MaHocVien = maHocVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HocPhi = hocPhi;
        }
    }
}
