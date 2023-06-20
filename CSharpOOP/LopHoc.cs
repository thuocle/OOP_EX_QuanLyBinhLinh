using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class LopHoc
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public string DiaChi { get; set; }
        public string GVCN { get; set; }

        public LopHoc()
        {
        }

        public LopHoc(int maLop, string tenLop, int siSo, string diaChi, string gVCN)
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            DiaChi = diaChi;
            GVCN = gVCN;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Lop {TenLop} ma lop {MaLop} o {DiaChi}");
            Console.WriteLine($"Co si so {SiSo} va GVCN la {GVCN}");
        }
    }
}
