using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classroom
{
    class LopHoc
    {
        private int _Size;
        private Student[] hocsinh;

        public LopHoc(int N)
        {
            this._Size = N;
            this.hocsinh = new Student[N];
        }


        public void TaoSanLopHoc()
        {
            if (_Size < 4 || this.hocsinh == null)
            {
                _Size = 4;
                hocsinh = new Student[4];
            }

            Student a = new Student("Nguyen", "A", 6, 7);
            hocsinh[0] = a;

            Student b = new Student("Tran", "B", 8, 9);
            hocsinh[1] = b;

            hocsinh[2] = new Student("Le", "C", 4, 3);
            
            hocsinh[3] = new Student();
            hocsinh[3].Surname = "Truong";
            hocsinh[3].Firstname ="D";
            hocsinh[3].Diem_van = 10;
        }

        //Xuất thông tin các học sinh của lớp học
        public void xuat()
        {
            foreach (Student x in hocsinh)
                if (x != null)
                    Console.WriteLine(x.CSV_Info);
        }

        public double TBVan()  
        {
            double res = 0;
            for (int i = 0; i < this._Size; i++)
            {
                res += hocsinh[i].Diem_van;
            }
            res = res / this._Size;
            return res;
        }
    }
}
