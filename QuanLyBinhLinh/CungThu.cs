using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBinhLinh
{
    public class CungThu:BinhLinh
    {
        public CungThu()
        {
            NhapThongTin();
        }
        public override void ChienDau(BinhLinh l)
        {
            base.ChienDau(l);
        }

        public override void InThongTin()
        {
            SucManh = TinhSucManh(1.3);
            base.InThongTin();
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
        }
    }
}
