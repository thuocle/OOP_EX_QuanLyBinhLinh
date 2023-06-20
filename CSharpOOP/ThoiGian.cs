using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class ThoiGian
    {
        private int _nam;
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam
        {
            get { return _nam; }
            set
            {
                _nam = value;
                if (DateTime.IsLeapYear(value)) LaNamNhuan = true;
                else LaNamNhuan = false;
            }
        }
        public bool LaNamNhuan { get; private set; }
        public int Thu { get; private set; }

        
        private void LaThu()
        {
            DateTime date = new DateTime(Nam, Thang, Ngay);
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Thu = 8;
                    break;
                case DayOfWeek.Monday:
                    Thu = 2;
                    break;
                case DayOfWeek.Tuesday:
                    Thu = 3;
                    break;
                case DayOfWeek.Wednesday:
                    Thu = 4;
                    break;
                case DayOfWeek.Thursday:
                    Thu = 5;
                    break;
                case DayOfWeek.Friday:
                    Thu = 6;
                    break;
                case DayOfWeek.Saturday:
                    Thu = 7;
                    break;
                default:
                    break;
            }
        }
        public void LayThongTin()
        {
            LaThu();
            Console.Write(Thu == 8 ? "Thoi gian hien tai la Chu Nhat, " : $"Thoi gian hien tai la Thu {Thu}, ");
            Console.Write($"ngay {Ngay}, thang {Thang}, nam {Nam}. ");
            Console.WriteLine(LaNamNhuan==true?"Day la nam nhuan":"Day khong la nam nhuan");
        }
        public void LayKhoangThoiGian(ThoiGian time)
        {
            DateTime timeStart = new DateTime(Nam, Thang, Ngay);
            DateTime timeEnd = new DateTime(time.Nam, time.Thang, time.Ngay);
            TimeSpan hour = timeEnd.Subtract(timeStart);
            Console.WriteLine($"Khoang thoi gian cua 2 ngay la: {hour.TotalHours} gio");
        }
        private int Nhap(string msg, string err, int min, int max)
        {
            int time;
            bool check;
            do
            {
                Console.WriteLine(msg);
                check = int.TryParse(Console.ReadLine(), out time);
                if(!check || time < min || time > max)
                {
                    Console.WriteLine(err);
                }
            } while (!check || time < min || time > max);
            return time;
        }
        private bool KiemTra()
        {
            if(Ngay > DateTime.DaysInMonth(Nam, Thang))
            {
                Console.WriteLine("Ngay thang nam khong ton tai!Nhap lai");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
            return true;
        }
        public ThoiGian()
        {
            do           
            {
                Ngay = Nhap("Nhap ngay: ", "Khong hop le", 1, 31);
                Thang = Nhap("Nhap thang: ", "Khong hop le", 1, 12);
                Nam = Nhap("Nhap nam: ", "Khong hop le", 1000, DateTime.Now.Year);
            } while (KiemTra() == false) ;
        }

        public ThoiGian(int ngay, int thang, int nam)
        {
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
        }
    }
}
