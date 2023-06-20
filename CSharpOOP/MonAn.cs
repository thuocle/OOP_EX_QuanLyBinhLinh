using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class MonAn
    {
        public string TenMonAn { get; set; }
        public int GiaBan { get; set; }
        public string GioiThieu { get; set; }
        public string NguyenLieuChinh { get; set; }

        public MonAn()
        {
        }

        public void InThongTin()
        {
            Console.WriteLine($"Mon {TenMonAn} {GioiThieu} duoc lam tu cac nguyen lieu chinh la: {NguyenLieuChinh} co gia {GiaBan}k");
        }
    }
}
