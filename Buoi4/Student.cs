using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    public class Student
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public Student() { }

        public Student(string mssv, string hoten, string gioitinh, double diem, string khoa)
        {
            MSSV = mssv;
            HoTen = hoten;
            GioiTinh = gioitinh;
            DiemTB = diem;
            Khoa = khoa;
        }
    }
}