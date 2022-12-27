using System;

namespace StackQueue
{
	class Node
	{
		public int data;
		public Node Next;

		public Node(int data, Node next)
		{
			this.data = data;
			this.Next = next;
		}
	}

	class SQ // base
	{
		protected Node Head = null;
		protected Node Tail = null;

		public Node Pop()
		{
			if (Head == null)
				return null;
			Node kq = Head;
			Head = Head.Next;
			if (Head == null) Tail = null;
			return kq;
		}

		public bool isEmpty()
		{
			return Head == null;
		}
	}

	class Stack :SQ
	{
		public void Push(int data)
		{
			Node x = new Node(data,Head);

			Head = x;

			if (Tail == null) Tail = x;
		}
	}

	class Queue : SQ
	{
		public void Add (int data)
		{
			Node x = new Node(data, null);
			Head = x;
			if (Head == null)
			{
				Head = Tail = x;
			}
			else
			{
				Tail.Next = x;
				Tail = x;
			}
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			Stack s = new Stack();
			s.Push(1);
			s.Push(2);
			s.Push(3);
			while (!s.isEmpty())
			{
				Node x = s.Pop();
				Console.WriteLine(x.data);
			}
		}
	}
}