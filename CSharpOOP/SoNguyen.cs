 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
   
    class SoNguyen
    {
        private int _so;
        public int GiaTri
        {
            get { return _so; }
            set
            {
                _so = value;
                LaSoChan = KiemTraChan();
                LaNguyenTo = KiemTraNguyenTo();
                LaSoDoiXung = KiemTraDoiXung();
            }
            
        }
        public bool LaSoChan { get; private set; }
        public bool LaNguyenTo { get; private set; }
        public bool LaSoDoiXung { get; private set; }

        public void InThongTin()
        {
            string SoChan = LaSoChan ? " La so chan" : " Khong la so chan";
            string SoNguyenTo = LaNguyenTo ? " La so nguyen to" : " Khong la so nguyen to";
            string SoDoiXung = LaSoDoiXung ? " La so doi xung" : " Khong la so doi xung";
            Console.WriteLine($"So nguyen {GiaTri}" + SoChan + SoNguyenTo + SoDoiXung);
        }
        public int Cong(SoNguyen a)
        {
            return GiaTri + a.GiaTri;
        }

        private bool KiemTraChan()
        {
            if (GiaTri % 2 == 0) return true;
            return false;
        }
        private bool KiemTraNguyenTo()
        {
            if (GiaTri <= 1) return false;
            if (GiaTri == 2) return true;
            if (GiaTri % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(GiaTri));

            for (int i = 3; i <= boundary; i += 2)
                if (GiaTri % i == 0)
                    return false;

            return true;
        }
        private bool KiemTraDoiXung()
        {
            char[] arrNum = GiaTri.ToString().ToCharArray();
            for (int i = 0; i < arrNum.Length; i++)
            {
                if (arrNum[i] != arrNum[arrNum.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public SoNguyen()
        {
            NhapSo();
        }

        public SoNguyen(int giaTri)
        {
            GiaTri = giaTri;
        }

        private void NhapSo()
        {
            Console.WriteLine("Nhap so nguyen: ");
            GiaTri = int.Parse(Console.ReadLine());
            while (!(GiaTri % 1 == 0 && GiaTri >= 0))
            {
                    Console.WriteLine("Nhap khong dung yeu cau! Nhap so nguyen: ");
                    GiaTri = int.Parse(Console.ReadLine());
            } 
        }
    }
}
