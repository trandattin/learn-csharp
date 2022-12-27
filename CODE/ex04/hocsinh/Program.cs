using System;

class Student
{
	public string _name;
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			this._name = value;
		}
	}	

	public double _math;

	public double Math
	{
		get
		{
			return this._math;
		}
		set
		{
			if (this._math < 0 || this._math >10)
			{
				throw new Exception("Math score must be in range [0,10]");				
			}
			this._math = value;
		}
	}
	public double _tinhoc;
	public double Tinhoc
	{
		get
		{
			return this._tinhoc;
		}
		set
		{
			if (this._tinhoc < 0 || this._tinhoc > 10)
			{
				throw new Exception("IT score must be in range [0,10]");
			}
			this._tinhoc = value;
		}
	}

	public double Avg
	{
		get
		{
			return (this._math + this._tinhoc)/2;
		}

		set
		{
			throw new Exception("Setting Avg value is not allowed");
		}
	}

	public Student(string name, double m, double i)
	{
		this.Name = name;
		this.Math = m;
		this.Tinhoc = i;
	}

	public Object this[int index]
	{
		get
		{
			switch (index)
			{
				case 0:
					return this.Name;
				case 1:
					return this.Math;
				case 2: 
					return this.Tinhoc;
				case 3:
					return this.Avg;
				default:
					throw new Exception("Invalid index");
			}
		}

		set
		{
			switch (index)
			{
				case 0:
					this.Name = (string)value;
					return;
				case 1:
					this.Math = Convert.ToDouble(value);
					return;
				case 2:
					this.Tinhoc = Convert.ToDouble(value);
					return;
		        case 3:
                    throw new Exception("this value can not be set manually");
                default:
                    throw new Exception("Invalid index");
			}
		}
	}
	public Object this[string index]
	{
		get
		{
			switch (index)
			{
				case "name":
					return this.Name;
				case "math":
					return this.Math;
				case "tinhoc":
					return this.Tinhoc;
				case "avg":
					return this.Avg;
				default:
					throw new Exception("Unknown index");
			}
		}	

		set
		{
			switch (index)
			{
				case "name":
					this.Name = (string)value;
					return;
				case "math":
					this.Math = Convert.ToDouble(value);
					return;
				case "tinhoc":
					this.Tinhoc = Convert.ToDouble(value);
					return;
				case "avg":
                    throw new Exception("this value can not be set manually");
                default:
  	                throw new Exception("Invalid index");
			}
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		Student tin = new Student("Tin",10,10);
		Console.WriteLine("Name: {0}, Math: {1}, Info: {2}, Avg: {3}",tin.Name,tin.Math,tin.Tinhoc,tin.Avg);
		Console.WriteLine("Name: {0}, Math: {1}, Info: {2}, Avg: {3}",tin[0],tin[1],tin[2],tin[3]);
		Console.WriteLine("Name: {0}, Math: {1}, Info: {2}, Avg: {3}",tin["name"],tin["math"],tin["tinhoc"],tin["avg"]);
		tin["name"] = "Thoa";
		tin["math"] = 9;
		tin["tinhoc"] = 9;
		Console.WriteLine("Name: {0}, Math: {1}, Info: {2}, Avg: {3}",tin["name"],tin["math"],tin["tinhoc"],tin["avg"]);
	}
}