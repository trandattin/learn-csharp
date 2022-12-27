using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classroom
{
    public class Student
    {
        //Field, biến
        private string surname;
        private string firstname;
        private double diem_van;
        private double diem_toan;

        //Thuộc tính
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public double Diem_van
        {
            get { return diem_van; }
            set { diem_van = value; }
        }

        public double Diem_toan
        {
            get { return diem_toan; }
            set { diem_toan = value; }
        }

        public double Diem_TB
        {
            get { return (diem_van +diem_toan)/2; }
        }

        // private double diem_tb; -->bỏ

        //Cóntructor
        public Student(string surname, string firstname, double diem_van, double diem_toan)
        {
            this.surname = surname;
            this.firstname = firstname;
            this.diem_van = diem_van;
            this.diem_toan = diem_toan;
        }
        public Student()
        {
            this.surname = "";
            this.firstname = "";
            this.diem_van = 0;
            this.diem_toan = 0;
        }

        //Thuộc tính: đổi thông tin 1 student thàng 1 chuỗi cách nhau bởi dấu ","
        public string CSV_Info
        {
            get { return Surname + "," + Firstname + "," + Diem_van + "," + diem_toan; }
        }
    }
}
