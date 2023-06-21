using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBinhLinh
{
    
    public abstract class BinhLinh
    {
        protected double _dame;
        public string Ten { get; set; }
        public double SucManh { get; set; }
        public bool TrangBi { get; set; }
        protected double TinhSucManh(double chiso)
        {
            if (TrangBi == true)
            {
                double strong = 50 * chiso;
                SucManh = strong;
            }
            else
            {
                SucManh = 50;
            }

            return SucManh;
        }
        public virtual void NhapThongTin()
        {
            Console.WriteLine("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Co trang bi hay khong (1:co / 2:khong)");
            int T = int.Parse(Console.ReadLine());
            switch (T)
            {
                case 1:
                    TrangBi = true;
                    break;
                case 2:
                    TrangBi = false;
                    break;
                default:
                    break;
            }
        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"{Ten} co suc manh {SucManh}");
        }
       
        public virtual void ChienDau(BinhLinh l)
        {
            if(SucManh > l.SucManh)
            {
                Console.WriteLine($"{Ten} thang {l.Ten}");
            }
            else if(SucManh < l.SucManh){
                Console.WriteLine($"{Ten} thua {l.Ten}");
            }
            else
            {
                Console.WriteLine($"{Ten} hoa {l.Ten}");
            }
        }
    }
}
