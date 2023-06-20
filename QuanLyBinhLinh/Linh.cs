using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBinhLinh
{
    public class Linh : BinhLinh
    {
        public Linh()
        {
            NhapThongTin();
        }
        
        public override void ChienDau(BinhLinh l)
        {
            base.ChienDau(l);
        }

        public override void InThongTin()
        {
            SucManh = TinhSucManh(1.1);
            base.InThongTin();
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
        }

       /* public override double TinhSucManh(double chiso)
        {
            return base.TinhSucManh(chiso);
        }*/
    }
}
