using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class SoPhuc
    {
        #region private field
        private double _phanThuc;
        private double _phanAo;
        #endregion

        #region public thuoc tinh
        public double PhanThuc { get; set; }
        public double PhanAo { get; set; }
        #endregion
      
        #region phuong thuc khoi tao
        public SoPhuc()
        {
        }

        public SoPhuc(double phanThuc, double phanAo)
        {
            PhanThuc = phanThuc;
            PhanAo = phanAo;
        }
        #endregion

        #region phuong thuc
        public void InThongTin()
        {
            Console.WriteLine($"{PhanThuc}+{PhanAo}");
        }
        #endregion
    }
}
