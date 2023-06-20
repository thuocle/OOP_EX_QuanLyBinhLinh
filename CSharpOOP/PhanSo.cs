using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class PhanSo
    {
        private int _mau;
        public int TuSo { get; set; }
        public int MauSo
        {
            get { return _mau; }
            set
            {
                _mau = value;
            }
        }

        public void InThongTin()
        {
            Console.WriteLine($"Phan so la {TuSo}/{MauSo}");
        }
        public int ToiGian()
        {
            int x = TuSo, y = MauSo;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            return MauSo = MauSo / x;
        }
        public void Cong(PhanSo a, PhanSo b)
        {
            a.ToiGian();
            b.ToiGian();
            if(a.MauSo != b.MauSo)
            {
                int mauchung = a.MauSo * b.MauSo;
                int tuA = a.TuSo * b.MauSo;
                int tuB = b.TuSo * a.MauSo;
                Console.WriteLine($"Tong hai phan so la {tuA + tuB}/{mauchung}");
            }
            else
            {
                Console.WriteLine($"Tong hai phan so la {a.TuSo + b.TuSo}/{a.MauSo}");
            }
        }
        public void Tru(PhanSo a, PhanSo b)
        {
            a.ToiGian();
            b.ToiGian();
            if (a.MauSo != b.MauSo)
            {
                int mauchung = a.MauSo * b.MauSo;
                int tuA = a.TuSo * b.MauSo;
                int tuB = b.TuSo * a.MauSo;
                Console.WriteLine($"Tong hai phan so la {tuA - tuB}/{mauchung}");
            }
            else
            {
                Console.WriteLine($"Tong hai phan so la {a.TuSo - b.TuSo}/{a.MauSo}");
            }
        }

        public PhanSo()
        {
            Console.WriteLine("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
            while (MauSo == 0)
            {
                Console.WriteLine("Nhap sai! Nhap lai mau so: ");
                MauSo = int.Parse(Console.ReadLine());
            }
        }

        public PhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
    }
}
