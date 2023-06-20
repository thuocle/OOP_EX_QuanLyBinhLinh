using System;
using static System.Console;
using System.Collections.Generic;
namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //doi tuong 1
            Nguoi nguoi = new Nguoi();// khai bao + khoi tao doi tuong 1,2,3,....n khong co tham truyen vao

            //gan du du lieu cho thuoc tinh
            nguoi.HoTen = "Nguyen Van A";
            nguoi.NamSinh = 2000;
            /*nguoi.NgheNghiep = "Ky su";*/
            nguoi.QueQuan = "Ha Noi";
         /*   nguoi.Luong = 2000;*/
            //cach goi phuong thuc
           /* nguoi.HienThiThongTin();*///doi tuong/lop.phuong thuc


            //doi tuong 2
            Nguoi nguoi2 = new Nguoi("Pham Thi B", 2001, "Ha Tinh","Hoa si", 900);// khai bao + khoi tao co tham so truyen vao
                                                                                  // goi phuong thuc
            /*  nguoi2.HienThiThongTin();*/


            //hs 1
            /* HocSinh hocsinh1 = new HocSinh();
             hocsinh1.NhapThongTinHS();
             hocsinh1.HienThiThongTinHS();*/

            //so phuc
            /*SoPhuc sophuc = new SoPhuc(2,1);
            sophuc.InThongTin();*/

            //sanpham
            /* SanPham sp1 = new SanPham(01,"Oto BenZ", "Oto", true);
             sp1.InThongTin();*/

            //mon an
            /*MonAn mon1 = new MonAn();
            mon1.TenMonAn = "Chan ga sa tac";
            mon1.GioiThieu = "la mot mon an quen thuoc voi gioi tre trong may nam vua qua";
            mon1.NguyenLieuChinh = "chan ga, sa, tac, V..v..";
            mon1.GiaBan = 100;
            mon1.InThongTin();*/

            //so thuc
            /* SoThuc sothuc1 = new SoThuc();
             SoThuc sothuc2 = new SoThuc();
             SoThuc sothuc3 = new SoThuc();
             SoThuc max = new SoThuc();
             SoThuc sqrt = new SoThuc();
             sothuc1.GiaTri = 5.5;
             sothuc2.GiaTri = 8.3;
             sothuc3.GiaTri = 9;
             Console.WriteLine($"So lan nhat la: {max.TimMax(sothuc1.GiaTri, sothuc2.GiaTri, sothuc3.GiaTri)}");
             Console.WriteLine($"Can bac hai cua {sothuc3.GiaTri} la {sothuc3.TinhCanBacN()}");*/

            //nhan vien
            /*   NhanVien nv = new NhanVien();
               nv.HoVaTen = "Nguyen Van A";
               nv.MaNhanVien = 001;
               nv.PhongBan = "Ke Toan";
               nv.SoDienThoai = "0124235365";
               nv.InThongTin();*/

            //Lop hoc
            /*  LopHoc lop = new LopHoc();
              lop.MaLop = 01;
              lop.TenLop = "10A2";
              lop.SiSo = 40;
              lop.DiaChi = "Phong 102 tang 3";
              lop.GVCN = "Co Ha";
              lop.InThongTin();*/

            //xuc xac
            /* TroChoiXucXac xx = new TroChoiXucXac();
             xx.BatDau();*/

            //hocsinhs
            /*hocsinhs hs = new hocsinhs();
            hocsinhs hs2 = new hocsinhs("Mai Tai Son", "10A2", new DateTime(2000, 6,6), 7.2, 7.5, 7);
            hs.InThongTin();
            hs2.InThongTin();*/

            //point 3d
            /* Point3D diemA = new Point3D();
             Point3D diemB = new Point3D();
             diemA.InThongTin();
             diemB.InThongTin();
             diemA.TimKhoangCach(diemB);*/

            //nguoi
            /*nguois nguoi3 = new nguois();
            nguois nguoi4 = new nguois(02,"Nguyen Cao Hoang Son Tu", new DateTime(2000,6,6));
            nguoi3.InThongTin();
            nguoi4.InThongTin();*/

            //dondathang
            /*DonDatHang don1 = new DonDatHang();*/
            /* DonDatHang don2 = new DonDatHang(02, new DateTime(2023,6,8), "Ti vi", 1500,5, "can than");

           *//*  don1.InThongTin();*//*
             don2.InThongTin();*/

            //hocvien

            /*  HocVien hv1 = new HocVien();
              HocVien hv2 = new HocVien(02, "Nguyen Nam Thao", new DateTime(2000, 6, 6), 5000000);
              HocVien hv3 = new HocVien(03, "Nguyen Nam Thang", new DateTime(2000, 6, 6), 5000000);
              HocVien hv4 = new HocVien(04, "Nguyen Van Thanh", new DateTime(2000, 6, 6), 5000000);
              HocVien hv5 = new HocVien(05, "Nguyen Thi Thao", new DateTime(2000, 6, 6), 5000000);

              List<HocVien> dshv= new List<HocVien> {};
              dshv.Add(hv1);
              dshv.Add(hv2);
              dshv.Add(hv3);
              dshv.Add(hv4);
              dshv.Add(hv5);
              hv1.TimKiemHocVien(dshv);
              *//*hv1.InThongTin(hv1);*/

            //SO nguyen
            /*  SoNguyen a = new SoNguyen();
              SoNguyen b = new SoNguyen();
              a.InThongTin();
              b.InThongTin();
              Console.WriteLine(a.Cong(b));*/

            // phan so
            /*  PhanSo p1 = new PhanSo();
              PhanSo p2 = new PhanSo();
              p1.Cong(p1, p2);
              p1.Tru(p1, p2);*/

            //dong ho
            /*DongHo dh1 = new DongHo();
            DongHo dh2 = new DongHo();
            dh1.LayThongTin();
            dh2.LayThongTin();
            dh1.LayKhoangThoiGian(dh2);*/

            //thoi gian
            /* ThoiGian time = new ThoiGian();
             ThoiGian time2 = new ThoiGian();
             time.LayThongTin();
             time2.LayThongTin();
             time.LayKhoangThoiGian(time2);*/
            //ma tran
            MaTran mt = new MaTran();
            MaTran mt2 = new MaTran();
            mt.InMaTran(mt);
            mt2.InMaTran(mt2);
            mt.CongMaTran(mt2);
            Console.ReadKey();
        }
    }
}
