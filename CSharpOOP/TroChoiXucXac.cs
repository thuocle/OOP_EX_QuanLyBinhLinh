using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class TroChoiXucXac
    {
        private int _giTri;
        public int GiaTri_1 { get; set; }
        public int GiaTri_2 
        {
          get  => _giTri;
            set
            {
                _giTri = value;
                if (GiaTri_1 > GiaTri_2) Thang = true;
                else if (GiaTri_1 < GiaTri_2) Thua = true;
                else
                {
                    Hoa = true;
                }
            }
        }
        public bool Thang { get; private set; }
        public bool Thua { get; private set; }
        public bool Hoa { get; private set; }

        public void BatDau()
        {
            do
            {
                NhapGiaTri();
                if (GiaTri_1 < 3 || GiaTri_1 > 18)
                {
                    Console.WriteLine("Tro choi ket thuc");
                    return;
                }
                Random rd = new Random();
                int m1 = rd.Next(1, 7);
                int m2 = rd.Next(1, 7);
                int m3 = rd.Next(1, 7);
                Console.WriteLine($"Cac mat dat duoc {m1} {m2} {m3}");
                GiaTri_2 = m1 + m2 + m3;
                Console.WriteLine($"Xuc xac dat duoc {m1+m2+m3}");
                InGiaTri();
                Thang = Thua = Hoa = false;
                Console.ReadKey();
                Console.Clear();
            } while (GiaTri_1 >= 3 && GiaTri_1 <= 18);
        }
        private void NhapGiaTri()
        {
            Console.WriteLine("Nhap gia tri muon dat: ");
            GiaTri_1 = int.Parse(Console.ReadLine());
        }
        private void InGiaTri()
        {
            Console.WriteLine(Thang?"Nguoi choi thang" : Thua? "Nguoi choi thua":"Hoa");
        }
    }
}
