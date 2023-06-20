using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class nguois
    {
        private string _hoTen;
        public int MaSo { get; set; }
        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                _hoTen = value;
                string[] arrHoTen = HoTen.Split(' ');
                Ho = arrHoTen.First();
                Ten = arrHoTen.Last();
                int n = arrHoTen.Length;
                for (int i = 1; i < n-1; i++)
                {
                    Dem += arrHoTen[i] + " ";
                }
                Dem = Dem.Trim();
            }
        }
        public DateTime NgaySinh { get; set; }
        public string Ho { get; private set; }
        public string Dem { get; private set; }
        public string Ten { get; private set; }

        public void InThongTin()
        {
            Console.WriteLine($"Ma so {MaSo} co ten la {HoTen} ngay sinh {NgaySinh.ToShortDateString()} co Ho la {Ho}, Dem la {Dem}, Ten la {Ten}");
        }
        public nguois()
        {
            Console.WriteLine("Nhap ma so: ");
            MaSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
        }

        public nguois(int maSo, string hoTen, DateTime ngaySinh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }
    }
}
