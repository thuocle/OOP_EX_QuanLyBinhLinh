using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class SoThuc
    {
        public double GiaTri { get; set; }
        public bool LaSoDuong { get; set; }

        public SoThuc()
        {
        }

        public double TimMax(SoThuc a, SoThuc b, SoThuc c)
        {
            if (a.GiaTri > b.GiaTri && a.GiaTri > c.GiaTri) return a.GiaTri;
            else if (c.GiaTri > b.GiaTri && c.GiaTri > b.GiaTri) return c.GiaTri;
            return b.GiaTri;
        }
        public double TinhCanBacN()
        {
            return Math.Sqrt(GiaTri);
        }
    }
}
