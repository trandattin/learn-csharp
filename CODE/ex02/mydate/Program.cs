// xay dung lai lop PhanSo phan truoc voi phuong khoi tao gom 2 phan so

using System;

namespace mydatee
{
	public class MyDate
	{
		private static int[]  day_in_month = new int[] {31,28,31,30,31,30,31,31,30,31,30,31};
		public int day;
		public int month;
		public int year;

		public MyDate(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public MyDate()
		{
			this.day = 0;
			this.month = 0;
			this.year = 0;
		}

		public void Xuat()
		{
			Console.WriteLine("Day: {0}",this.day);
			Console.WriteLine("Month: {0}",this.month);
			Console.WriteLine("Year: {0}",this.year);
		}

		public bool leapYear()
		{
			if (this.year % 100 == 0)
			{
				if (this.year % 400 == 0)
					return true;
				else
					return false;
			} 
			else if (this.year % 4 == 0)
				return true;
			else 
				return false;
		}

		public int countDateMonth()
		{
			int count_date = day_in_month[this.month-1];
			if (count_date == 28 && leapYear())
				return count_date+1;
			else
				return count_date;
		}

		public MyDate nextDay()
		{
			MyDate next_day = new MyDate();
			if (this.day == countDateMonth())
			{
				if (this.month == 12)
				{
					next_day.year = this.year + 1;
					next_day.month = 1;
					next_day.day = 1;
				}
				else if(this.month == 2 && leapYear() && this.day == 28)
				{
					next_day.year = this.year;
					next_day.month = this.month;
					next_day.day = 29;
				}
				else
				{
					next_day.month = this.month + 1;
					next_day.day = 1;
					next_day.year = this.year;
				}
			} 
			else 
			{
				next_day.day = this.day + 1;
				next_day.month = this.month;
				next_day.year = this.year;
			}
			return next_day;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			MyDate date = new MyDate(28,2,2000);
			date.Xuat();
			Console.WriteLine("{0} in {1} have {2} days",date.month,date.year,date.countDateMonth());
			MyDate date2 = date.nextDay();
			date2.Xuat();
		}
	}
}