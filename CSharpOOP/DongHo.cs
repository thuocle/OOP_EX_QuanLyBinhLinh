using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class DongHo
    {
        private int _gio;
        public int Gio
        {
            get { return _gio; }
            set
            {
                _gio = value;
                if(value <= 12)
                {
                    LaBuoiSang = true;
                }
                else
                {
                    LaBuoiSang = false;
                }
            }
        }
        public int Phut { get; set; }
        public int Giay { get; set; }
       
        public bool LaBuoiSang { get; private set; }

        public void LayThongTin()
        {
                Console.WriteLine($"{Gio}:{Phut}:{Giay}");
                Console.WriteLine(LaBuoiSang ? "Bay gio dang la buoi sang":"Bay gio dang la buoi chieu") ;
        }
        public void LayKhoangThoiGian(DongHo b)
        {
            int gio, phut, giay ;
            gio = b.Gio - Gio - 1;
            phut = Phut == 0 ? phut = b.Phut : phut = b.Phut + (60 - Phut)-1; 
            giay = Giay == 0 ? giay = b.Giay : giay = b.Giay + (60 - Giay);
            if (giay >= 60 && b.Giay != Giay)
            {
                phut += 1;
                giay = giay - 60;
            }
            if (phut >= 60 && b.Phut != Phut)
            {
                gio += 1;
                phut = phut - 60;
            }
            if (b.Giay == Giay)
            {
                giay = 0;
            }
            if (b.Phut == Phut)
            {
                phut = 0;
            }

            Console.WriteLine($"Khoang thoi gian giua hai khung gio la {gio}:{phut}:{giay}");
        }

        public DongHo()
        {
            NhapGio();
            NhapPhut();
            NhapGiay();
        }
        private void NhapGio()
        {
            Console.WriteLine("Nhap gio:");
            Gio = int.Parse(Console.ReadLine());
            while (!(Gio>=0 && Gio <= 24 && Gio % 1 == 0))
            {
                Console.WriteLine("Khong dung dinh dang! Hay nhap lai gio:");
                Gio = int.Parse(Console.ReadLine());
            }
        }private void NhapPhut()
        {
            Console.WriteLine("Nhap phut:");
            Phut = int.Parse(Console.ReadLine());
            while(!(Phut>=0 && Phut <= 60 && Phut % 1 == 0))
            {
                Console.WriteLine("Khong dung dinh dang! Hay nhap lai phut:");
                Phut = int.Parse(Console.ReadLine());
            }
        }private void NhapGiay()
        {
            Console.WriteLine("Nhap giay:");
            Giay = int.Parse(Console.ReadLine());
            while(!(Giay >= 0 && Giay <= 60 && Giay % 1 == 0))
            {
                Console.WriteLine("Khong dung dinh dang! Hay nhap lai giay:");
                Giay = int.Parse(Console.ReadLine());
            }
        }
    }
}
