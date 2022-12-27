using System;

namespace LopLongNhau
{
	public class Person 
	{
		private String name;
		public Person(string name)
		{
			this.name = name;
		}

		private void ShowSecret()
		{
			Console.WriteLine(name);
		}

		private static void DoSomeThing()
		{
			Console.WriteLine("Ham static cua lop person");
		}

		class Diary
		{
			public void Logging()
			{
				DoSomeThing();
				Person p = new Person("Nguyen Van A");
				p.ShowSecret();
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person.DoSomeThing();
		}
	}
}