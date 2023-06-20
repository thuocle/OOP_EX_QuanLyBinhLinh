using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
   public class Nguoi
    {
        #region PRIVATE
        //field -- truong luu tru du lieu  === tinh dong goi che giau du lieu
        private string _hoTen;
        private int _namSinh;
        private string _queQuan;
        private string _ngheNghiep;
        private int _luong;
        #endregion

        #region PUBLIC
        //thuoc tinh
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string NgheNghiep { get; set; }
        public int Luong
        {
            get
            {
                if (_luong > 2000)
                    return _luong;
                else
                    return _luong + 500;
            }
            set 
            {
                if (value < 1000)
                    _luong = 0;
                else
                    _luong = value; 
            }
        }
        #endregion
        public Nguoi()  //ham khoi khong tham so
        {

        }

        public Nguoi(string hoTen, int namSinh, string queQuan, string ngheNghiep, int luong)//ham khoi tao co tham so
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            QueQuan = queQuan;
            NgheNghiep = ngheNghiep;
            Luong = luong;
        }

        //phuong thuc - giong nhu function (co them pham vi truy cap)
        public void NhapThongTin()
        {
            Console.Write("Nhap ten:");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh:");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan:");
            QueQuan = Console.ReadLine();
        }
        public void HienThiThongTin (/*params*/)
        {
            Console.WriteLine("===========");
            //cau lenh
            Console.WriteLine($"Ho ten: {HoTen}\nNam sinh: {NamSinh} \nQue quan: {QueQuan}");
            Console.WriteLine("===========");
        }
    }
}
