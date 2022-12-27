// Bài 4: Xây dựng lớp hàng đợi Queue lưu trữ dữ liệu số nguyên bằng mảng với các thao tác trên hàng đợi

using System;

namespace queue
{
    public class Queue
    {
        private int[] _Data;
        private int _Size = 0;
        private int _Head = 0;

        public Queue(int size)
        {
            this._Size = size;
            this._Head = size;
            this._Data = new int[size];
        }

        public void In(int n)
        {
            if (this._Head == 0)
            {
                throw new ArgumentException("Queue is already full");
            }
            this._Head--;
            this._Data[this._Head] = n;
        }

        public int Out()
        {
            if (this._Head == this._Size)
            {
                throw new ArgumentException("Queue is empty");
            }
            int res = this._Data[this._Size - 1];
            for (int i = this._Size - 1; i > this._Head; i--)
            {
                this._Data[i] = this._Data[i - 1];
            }
            this._Head++;
            return res;
        }

        public void Debug()
        {
            for (int i = 0; i < this._Size; i++)
            {
               if (i < this._Head) Console.Write("* ");
              else Console.Write("{0} ", this._Data[i]);
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(5);
            try { q.Out(); } catch (System.Exception e) { Console.WriteLine("{0}", e.Message); } // empty
            q.In(4);
            q.Debug();
            q.In(3);
            q.Debug();
            q.In(2);
            q.Debug();
            q.In(7);
            q.Debug();
            q.In(9);
            q.Debug();
            q.Out();
            q.Out();
            q.Out();
            q.Debug();
        }
    }
}
