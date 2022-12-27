using System.Collections;

public class Transport
{
	protected string RenderName { get; set; }
	protected int HourLent {get; set; }
	public string Type {get; set;}

	public virtual int LentCost
	{
		get {return 0;}
	}
	public virtual void OutPut()
	{
	}

	public virtual string ID()
	{
		return "T";
	}
}

public class Moto : Transport
{
	protected string LicensePlates {get;set;}

	public Moto(string rendername, int hourlent, string type, string licenseplates)
	{
		this.RenderName = rendername;
		this.HourLent = hourlent;
		this.Type = type;
		this.LicensePlates = licenseplates;
	}

	public override int LentCost
	{
		get
		{
			int T;
			if (this.Type == "100")
			{
				T = 15000;
			}
			else
			{
				T = 20000;
			}
			if (HourLent > 1) 
				T = T + 10000*(this.HourLent-1);
			return T;
		}
	}

	public override string ID()
	{
		return "Moto";
	}

	public override void OutPut()
	{
		Console.WriteLine(this.RenderName + "\t" + this.HourLent + "\t" + this.LentCost + "\t" + this.Type + "\t" + this.LicensePlates);
	}
}

public class Bicycle : Transport
{
	public Bicycle(string rendername, int hourlent)
	{
		this.RenderName = rendername;
		this.HourLent = hourlent;
		this.Type = "";
	}

	public override int LentCost
	{
		get
		{
			if (HourLent == 1)
				return 10000;
			return 10000 + 80000*(HourLent-1);
		}
	}

	public override string ID()
	{
		return "Bicycle";
	}

	public override void OutPut()
	{
		Console.WriteLine(this.RenderName + "\t" + this.HourLent + "\t" + this.LentCost);
	}
}

public class STORE
{
	int NumberTransport;
	List<Transport> list_trans = new List<Transport>{};
	public STORE(int n)
	{
		NumberTransport = n;
	}

	public int menu()
	{
		int flag;
		do {
			Console.WriteLine("****TABLE TYPE OF TRANSPORT****");
			Console.WriteLine("1. Bicycle");
			Console.WriteLine("2. Moto");
			flag = int.Parse(Console.ReadLine());
		}while(flag != 1 && flag != 2);
		return flag;
	}

	public void InputListTranport()
	{
		int flag;
		flag = menu();
		if (flag == 1)
		{
			Console.WriteLine("*****BICYCLE*******");
			Console.WriteLine("Render name");
			string name = Console.ReadLine();
			Console.WriteLine("Hour Lent");
			int hl=int.Parse(Console.ReadLine());
			list_trans.Add(new Bicycle(name,hl));
		} 
		else
		{
			Console.WriteLine("*****BICYCLE*******");
			Console.WriteLine("Render name");
			string name = Console.ReadLine();
			Console.WriteLine("Hour Lent");
			int hl=int.Parse(Console.ReadLine());
			Console.WriteLine("100 or 250 cc?");
			string type = Console.ReadLine();
			Console.WriteLine("License Plates?");
			string lp = Console.ReadLine();
			list_trans.Add(new Moto(name,hl,type,lp));
		}
	}

	public void OutputTransPort()
	{
		foreach(Transport s in this.list_trans) 
		{
			s.OutPut();
		}
	}

	public long TotalCost()
	{
		long sum = 0;
		foreach(Transport t in this.list_trans) 
		{
            sum += t.LentCost;
        }
		return sum;
	}
	public void OutPutBicycle()
	{
		foreach(Transport s in this.list_trans)  
		{
            if (s.ID() != "Bicycle") 
				continue;
            s.OutPut();
		}
	}
	public long SumMoto250()
	{
		long T = 0;
		foreach(Transport s in this.list_trans)
		{
			if (s.ID() == "Moto")
				if(s.Type == "250")
					T += s.LentCost;
		}
		return T;
	}
}

public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Number of Transport?");
		int n = int.Parse(Console.ReadLine());
		STORE TINTRAN = new STORE(2);
		Console.WriteLine("\n1.INPUT");
		TINTRAN.InputListTranport();
		Console.WriteLine("\n2.OUTPUT");
		TINTRAN.OutputTransPort();
		Console.WriteLine("\n3.TOTAL COST");
		TINTRAN.TotalCost();
		Console.WriteLine("\n4. OUTPUT BICYCLE");
		TINTRAN.OutPutBicycle();
		Console.WriteLine("\n5. TOTAL MOTO 250");
		TINTRAN.SumMoto250();
	}
}