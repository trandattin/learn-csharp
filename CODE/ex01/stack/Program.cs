/*
Bai 3: Xay dung lop ngan xep Stack luu tru dữ liệu số nguyên bằng mảng với các
thao tác cơ bản: Push, Pop, kiểm tra tràn stack, kiểm tra stack rỗng. Dữ liệu của một đối tượng thuộc lớp Stack gồm: Data (mảng số nguyên), Size (kích thước của mảng Data), Top(chỉ số của phần tử nằm trên đỉnh Stack)
*/

using System;

namespace stack
{
    public class Stack
    {
        private int[] _Data;
        private int _Size = 0;
        private int _Top = 0;

        public Stack (int size)
        {
            this._Size = size;
            this._Top = 0;   
            this._Data = new int[size];
        }

        public void Push (int element)
        {
            if (this._Top == _Size)
            {
                throw new ArgumentException("Stack is already full");
            }
            this._Data[this._Top] = element;
            this._Top++;
        }

        public int Pop()
        {
            if (this._Top == 0)
            {
                throw new ArgumentException("Stack is empty");
            }
            int res = this._Data[this._Top-1];
            this._Top--;

            return res;
        }

        public void isEmpty()
        {
            if (this._Top == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack is not empty");
            }
        }

        public void isFull()
        {
            if (this._Top == this._Size)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                Console.WriteLine("Stack is not full");
            }
        }

        public void Debug()
        {
            for (int i = this._Size-1; i >= 0; i--)
            {
               if (i < this._Top) 
                    Console.Write("{0} ", this._Data[i]);
               else 
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack t = new Stack(5);
            try { t.Pop(); } catch (System.Exception e) { Console.WriteLine("{0}", e.Message); }
            t.isEmpty();
            t.Push(5);
            t.Debug();
            t.isEmpty();
            t.Push(4);
            t.Push(4);
            t.Push(4);
            t.Push(4);
            t.isFull();
        }
    }
}
