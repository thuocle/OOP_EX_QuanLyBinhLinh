using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class MaTran
    {
        private int[,] _element;
        public int SoHang { get; set; }
        public int SoCot { get; set; }
        public int[,] MaTrix
        {
            get { return _element; }
            set
            {
                _element = value;
            }
        }

        public void InMaTran(MaTran m)
        {
            Console.WriteLine("Ma tran: ");
                for (int i = 0; i < m.SoHang; i++)
                {
                    for (int j = 0; j < m.SoCot; j++)
                    {
                        Console.Write($"[{i}{j}] = { m.MaTrix[i, j]}\t");
                    if (j == m.SoCot-1)
                    {
                        Console.WriteLine();
                    }
                    }
                }
            
        } 
        public void NhapMaTran( )
        {
            Console.WriteLine("Nhap so hang: ");
            SoHang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            SoCot = int.Parse(Console.ReadLine());
            MaTrix = new int[SoHang, SoCot];
            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write($"[{i}{j}] = ");
                    MaTrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void CongMaTran(MaTran mt)
        {
            MaTran newMatrix = new MaTran(SoHang, SoCot, new int[SoHang, SoCot]);
            if(mt.SoCot != SoCot || mt.SoHang != SoHang)
            {
                Console.WriteLine("Hai ma tran cung cap moi cong duoc!");
            }
            else
            {
                for (int i = 0; i < SoHang; i++)
                {
                    for (int j = 0; j < SoCot; j++)
                    {
                        newMatrix.MaTrix[i, j] = MaTrix[i, j] + mt.MaTrix[i, j];
                    }
                }
            }
            Console.WriteLine("Hai ma tran co tong la: ");
            InMaTran(newMatrix);
        }
        public MaTran()
        {
            NhapMaTran();
        }

        public MaTran(int soHang, int soCot, int[,] maTrix)
        {
            SoHang = soHang;
            SoCot = soCot;
            MaTrix = maTrix;
        }
    }
}
