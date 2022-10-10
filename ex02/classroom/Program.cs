/*
Bài 2: Viết chương trình nhập một lớp gồm N học sinh, mỗi học sinh có các thông tin như: họ,
tên, điểm văn, điểm toán, điểm trung bình. Tính điểm trung bình của từng học sinh theo công thức: 
(điểm văn + điểm toán)/2
1. Tính trung bình điểm văn của cả lớp.
2. Tính trung bình điểm toán của cả lớp.
3. Sắp xếp học sinh trong lớp theo thứ tự họ tên.
4. Sắp xếp học sinh trong lớp theo thứ tự không giảm của điểm trung bình, nếu điểm trung bình
bằng nhau thì sắp xếp theo tên.
*/

using System;

namespace classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            LopHoc A8 = new LopHoc(N);
            A8.TaoSanLopHoc();
            A8.xuat();
            double tb_van = A8.TBVan();
            Console.WriteLine("TB Van: {0}",tb_van);
        }
    }
}