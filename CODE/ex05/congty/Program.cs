using System;

namespace CongTy{

	class NhanVien
	{
		protected string _name;
		protected double _salary;
		protected double _workingdays;
		protected double _allowanceBase = 2000;
        protected double _allowanceRate = 0;

		public string name
		{
			get { return this._name;}
			set { this._name = value;}
		}

		public double salary
		{
			get { return this._salary;}
			set { this._salary = value;}
		}
		public double workingdays
		{
			get { return this._workingdays;}
			set { this._workingdays = value;}
		}

		public NhanVien(string name)
		{
			this._name = name; 
            this._salary = 120*20;
            this._allowanceBase = 2000;
            this._allowanceRate = 0;
		}

		public Double income() {
            return this._salary + this._allowanceBase*this._allowanceRate;
		}
		public virtual void Print(){
		}
	}

	class Director : NhanVien
	{
		private List<Manager> managers = new List<Manager>{};
        public int TotalEmployees = 0;

		public Director(string name): base(name) {
            base._allowanceRate = 2.5;
        }

		public Manager AddManager(string name) 
		{
            Manager s = new Manager(name, this);
            this.managers.Add(s);
            this.TotalEmployees += 1;
            return s;
        }

		public override void Print()
        {
        	foreach (Manager x in managers)
			{
            	Console.WriteLine("Name: {0}",this.name); 
            	Console.WriteLine("Income: {0}",this.income()); 
            	Console.WriteLine("Total Employees: {0}",this.TotalEmployees); 
        	}
		}
	}

	class Manager : NhanVien
	{
		private List<Staff> staffs = new List<Staff>{};
		private Director boss;
		protected int TotalEmployees = 0;

		public Manager(string name, Director boss): base(name) 
		{
            base._allowanceRate = 1;
            this.boss = boss;
        }

		public Staff AddStaff(string name) {
            Staff s = new Staff(name, this);
            this.staffs.Add(s);
            this.TotalEmployees += 1;
            this.boss.TotalEmployees += 1;
            return s;
        }

		public override void Print()
        {
        	foreach (Staff x in staffs)
			{
            	Console.WriteLine("Name: {0}",this.name); 
            	Console.WriteLine("Boss: {0}",this.boss); 
            	Console.WriteLine("Income: {0}",this.income()); 
            	Console.WriteLine("Total Employees: {0}",this.TotalEmployees); 
        	}
		}
	}

	class Staff : NhanVien
	{
		private Manager boss;
        public Staff(String name, Manager quanly): base(name) 
		{
            this.boss = quanly;
        }

		public override void Print()
        {
            Console.WriteLine("Name: {0}",this.name); 
            Console.WriteLine("Boss: {0}",this.boss); 
            Console.WriteLine("Income: {0}",this.income()); 
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<NhanVien> es = new List<NhanVien>{};

            Director d1 = new Director("Giám đốc 1");
            Director d2 = new Director("Giám đốc 2");

            Manager m11 = d1.AddManager("Trường phòng 11");
            Manager m12 = d1.AddManager("Trường phòng 12");
            Manager m21 = d2.AddManager("Trường phòng 21");

            Staff s111 = m11.AddStaff("Nhân viên 111");
            Staff s121 = m12.AddStaff("Nhân viên 121");
            Staff s122 = m12.AddStaff("Nhân viên 121");
            Staff s211 = m21.AddStaff("Nhân viên 211");
            Staff s212 = m21.AddStaff("Nhân viên 212");

            es.Add(d1);
			// es[0]= d1
            es.Add(d2);
            es.Add(m11);
            es.Add(m12);
            es.Add(m21);
            es.Add(s111);
            es.Add(s121);
            es.Add(s122);
            es.Add(s211);
            es.Add(s212);
            foreach (var e in es)
            {
                e.Print();
            }
		}
	}
}