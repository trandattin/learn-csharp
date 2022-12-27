using System.Collections;

public class Insurance
{
	public string Buyer {get; set;}
	public int Months {get; set;}
	public double Cost {get; set;}
	public double Comission {get; set;}

	public virtual void OutPut()
	{
	}

	public virtual string ID()
	{
		return "I";
	}
}

public class ShortTerm : Insurance
{
	public ShortTerm(string buyer, int months, double cost)
	{
		Buyer = buyer;
		Months = months;
		Cost = cost;
		Comission = Cost*5/100;
	}

	public override void OutPut()
	{
		Console.WriteLine("Short Term Type: " + Buyer + "\t" + Months + "\t" + Cost);
	}
	
	public override string ID()
	{
		return "ST";
	}
}

public class LongTerm : Insurance
{
	public double CostPerMonth {get; private set;}
	public LongTerm(string buyer, int months, double cost) 
	{
		Buyer = buyer;
		Months = months;
		Cost = cost;
		this.CostPerMonth = Cost/Months;
		Comission = this.CostPerMonth/2;
	}
	public override void OutPut()
	{
		Console.WriteLine("Long Term Type: "+ Buyer + "\t" + Months + "\t" + Cost);
	}
		
	public override string ID()
	{
		return "LT";
	}
}

public class Staff : IComparable
{
	public string Name {get; private set;}
	public double SalaryRate {get; private set;}
	public ArrayList Insurances = new ArrayList();

	public double TotalCost
	{
		get
		{
			double s = 0;
			foreach(Insurance i in this.Insurances)
			{
				s += i.Cost;
			}
			return s;
		}
	}
	public double Reward
	{
		get
		{
			foreach (Insurance i in this.Insurances)
			{
				if(i.Cost >10000)
				{
					return 100;
				}
			}
			return 0;
		}
	}
	public double Penalty
	{
		get
		{
			double s = 0;
			foreach (Insurance i in this.Insurances)
			{
				s+=i.Cost;
			}
			if (s < 10000)
				return 30;
			return 0;
		}
	}
	public double Income
	{
		get
		{
			return 40*this.SalaryRate + (1/100)*this.TotalCost;
		}
	}
	public double Comission
	{
		get 
		{
			double s = 0;
			foreach(Insurance i in this.Insurances)
			{
				s += i.Comission;
			}
			return s;
		}
	}

	public Staff(string name, double salaryrate)
	{
		this.Name = name;
		this.SalaryRate = salaryrate;
	}

	public void OutPut()
	{
		Console.WriteLine(Name + "\t" + SalaryRate);
		foreach(Insurance i in this.Insurances)
		{
			i.OutPut();
		}
		Console.WriteLine();
	}

	public int CompareTo(object y)
	{
		if (this.TotalCost > ((Staff)y).TotalCost) {
            return 0;
        }
        return 1;
	}
}

public class Company
{
	public int NumberStaffs;
	List<Staff> StaffList = new List<Staff>{};
	public Company(int numberstaffs)
	{
		this.NumberStaffs = numberstaffs;
	}
	public int WhichInsurance()
	{
		int tmp;
		do
		{
			Console.WriteLine("*** INPUT TABLE ***");
			Console.WriteLine("1. INPUT SHORT TERM INSURANCE");
			Console.WriteLine("2. INPUT LONG TERM INSURANCE");
			tmp = int.Parse(Console.ReadLine());
		}while((tmp != 1) && (tmp != 2));
		return tmp;
	}
	
	public Staff InputOneStaff()
	{
		Console.WriteLine("Name? ");
		string name = Console.ReadLine();
		Console.WriteLine("SalaryRate? ");
		double sr = double.Parse(Console.ReadLine());
		Staff nv = new Staff(name,sr);
		Console.WriteLine("How many number of insurrances for this staff?");
		int numberInsurrance = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberInsurrance; i++)
		{
			int flag = WhichInsurance();
			if (flag == 1)
			{
				Console.WriteLine("*****SHORT TERM INSURANCE*****");
				Console.WriteLine("Buyer? ");
				string buyer = Console.ReadLine();
				Console.WriteLine("Months? ");
				int months = int.Parse(Console.ReadLine());
				Console.WriteLine("Cost? ");
				double cost = double.Parse(Console.ReadLine());
				ShortTerm k = new ShortTerm(buyer,months,cost);
				nv.Insurances.Add(k); 
			}
			if (flag == 2)
			{
				Console.WriteLine("*****LONG TERM INSURANCE*****");
				Console.WriteLine("Buyer? ");
				string buyer = Console.ReadLine();
				Console.WriteLine("Months? ");
				int months = int.Parse(Console.ReadLine());
				Console.WriteLine("Cost? ");
				double cost = double.Parse(Console.ReadLine());
				nv.Insurances[i] = new LongTerm(buyer,months,cost);
			}
		}
		return nv;
	}

	public void InputStaffs()
	{
		for (int i = 0; i < this.NumberStaffs; i++)
		{
			Staff s = InputOneStaff();
			StaffList.Add(s);
		}
	}

	public void OutputStaff()
	{
		foreach(Staff s in this.StaffList)
		{
			s.OutPut();
		}
	}

	public void OutputStaffWithComissionCondition()
	{
		foreach(Staff s in this.StaffList)
		{
			if (s.Comission > 500)
				s.OutPut();
		}
	}

	public void WhoGetsFined()
	{
		foreach(Staff s in this.StaffList)
		{
			if (s.Penalty > 0)
				s.OutPut();
		}
	}

	public void WhoGet100()
	{
		foreach(Staff s in this.StaffList)
		{
			if (s.Reward > 0)
				s.OutPut();
		}
	}

	public void Sort()
	{
		StaffList.Sort();
	}
}
public class Program
{
	public static void Main()
	{
		int n;
		Console.WriteLine("How many Staff?");
		n = int.Parse(Console.ReadLine());
		
		Company cpn = new Company(n);
		
		Console.WriteLine("1.Input Staff");
		cpn.InputStaffs();

		Console.WriteLine("\n2. Output Staff\n");
		cpn.OutputStaff();

		Console.WriteLine("\n3. Comission > 500");
		cpn.OutputStaffWithComissionCondition();

		Console.WriteLine("\n4. Who gets fined?");
		cpn.WhoGetsFined();

		Console.WriteLine("\n5. Who gets 100USD");
		cpn.WhoGet100();

		Console.WriteLine("\n6. Sort Staff by Total Cost");
		cpn.Sort();
		cpn.OutputStaff();
	}
}