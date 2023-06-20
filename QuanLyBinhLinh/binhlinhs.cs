using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBinhLinh
{
   public class binhlinhs
    {
        protected double _st;
        public string Ten { get; set; }
        public double SucManh
        {
            get { return _st; }
            set
            {
                _st = 50;
            }
        }
        public bool TrangBi { get; set; }
        public binhlinhs()
        {
           /* SucManh = SucManh;*/
            Nhap();
        }

        public binhlinhs(string ten, double sucManh, bool trangBi)
        {
            Ten = ten;
            SucManh = sucManh;
            TrangBi = trangBi;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten: ");
            Ten = Console.ReadLine(); 
            Console.WriteLine("Co trang bi khong: 1: co/ 2: khong");
            int lc = int.Parse(Console.ReadLine());
            SucManh = SucManh;
            if(lc == 1)
            {
                TrangBi = true;
            }
            else
            {
                TrangBi = false;
            }
        }

        public void Hien()
        {
            Console.WriteLine($"{Ten} co suc manh {SucManh} ");
            Console.Write(TrangBi ? "Co trang bi" : "Khong co trang bi");
        }
    }
}
