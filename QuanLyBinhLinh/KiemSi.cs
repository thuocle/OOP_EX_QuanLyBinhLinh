﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBinhLinh
{
   public class KiemSi:BinhLinh
    {
        public KiemSi()
        {
            NhapThongTin();
        }

        public override void ChienDau(BinhLinh l)
        {
            base.ChienDau(l);
        }

        public override void InThongTin()
        {
            base.InThongTin();
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
        }
    }
}
