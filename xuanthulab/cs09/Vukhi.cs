using System;

namespace cs09{

	class Vukhi {
		// DU LIEU
		public string name = "Ten vu khi";
		int dosatthuong = 0;

		// Thuoc tinh

		public int satThuong{
			// =
			set {
				dosatthuong = value;
			}
			// Truy cap
			get {
				return dosatthuong;
			}
		}


		// Phuong thuc khoi tao
		public Vukhi(){
			dosatthuong = 1;
		}

		public Vukhi(string name, int dosatthuong){	
			this.dosatthuong = dosatthuong;
			this.name = name;
		}

		// PHUONG THUC

		public void thietLapSathuong(int dosatthuong){
			this.dosatthuong = dosatthuong;
		}

		public void tanCong(){
			Console.Write(this.name);
			for (int i = 0; i < dosatthuong; i++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}
}