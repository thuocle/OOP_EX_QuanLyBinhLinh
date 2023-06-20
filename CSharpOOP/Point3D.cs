using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D()
        {
            Console.WriteLine("Nhap toa do XYZ: ");
            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            Z = double.Parse(Console.ReadLine());
        }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void InThongTin()
        {
            Console.WriteLine($"({X}, {Y}, {Z})");
        }
        public void TimKhoangCach(Point3D diemB)
        {
            double d = Math.Sqrt(Math.Pow(X - diemB.X, 2)+ Math.Pow(Y - diemB.Y, 2)+ Math.Pow(Z - diemB.Z, 2));
            Console.WriteLine($"Khoang cach cua A va B la: {d}");
        }
    }
}
