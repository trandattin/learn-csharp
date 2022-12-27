// Xây dựng lớp MaTranVuong với các phương thức và các toán tử +,-,*,/ ép sang kiểu số thực (trả về định thức của ma trận)

using System;

class MaTranVuong
{
	public int _size;
	public int[][] element;

	// constructor
	public MaTranVuong(int size)
	{
		this._size = size;
		this.element = new int[size][];
		for (int i = 0; i < this._size; i++)
		{
			element[i] = new int[size];
		}
	}
	public void inputMatrix()
	{
		for (int i = 0; i < this._size; i++)
		{
			for (int k = 0; k < this._size; k++)
			{
				int e = int.Parse(Console.ReadLine());
				element[i][k] = e;
			}
		}
	}

	public String Info
	{
		get
		{
			string s = "";
			for (int i = 0; i < this._size; i++)
			{
				for(int k = 0; k < this._size; k++)
				{
					s = s + element[i][k] + "  ";
				}
				s = s + "\n";
			}
			return s;
		}
	}

	public static MaTranVuong operator +(MaTranVuong A, MaTranVuong B)
	{
		if (A._size != B._size)
		{
			throw new ArgumentException("Different size");
		} 
		else
		{
			MaTranVuong C = new MaTranVuong(A._size);
			for (int i = 0; i < A._size; i++)
			{
				for (int k = 0; k < A._size; k++)
				{
					C.element[i][k] = A.element[i][k] + B.element[i][k];
				}
			}
			return C;
		}
		
	}
	public static MaTranVuong operator -(MaTranVuong A, MaTranVuong B)
	{
		if (A._size != B._size)
		{
			throw new ArgumentException("Different size");
		} 
		else
		{
			MaTranVuong C = new MaTranVuong(A._size);
			for (int i = 0; i < A._size; i++)
			{
				for (int k = 0; k < A._size; k++)
				{
					C.element[i][k] = A.element[i][k] - B.element[i][k];
				}
			}
			return C;
		}
	}
	
	public static MaTranVuong operator *(MaTranVuong A, MaTranVuong B)
	{
		if (A._size != B._size)
		{
			throw new ArgumentException("Different size");
		} 
		else
		{
			MaTranVuong C = new MaTranVuong(A._size);
			for (int i = 0; i < A._size; i++)
			{
				for (int k = 0; k < A._size; k++)
				{
					int sum = 0;
					for (int r = 0; r < A._size; r++)
					{
						sum += A.element[i][r]*B.element[r][k];
					}
					C.element[i][k] = sum;
				}
			}
			return C;
		}
	}

	public static MaTranVuong operator /(MaTranVuong A, MaTranVuong B)
	{
		if (A._size != B._size)
		{
			throw new ArgumentException("Different size");
		} 
		else
		{
			MaTranVuong C = new MaTranVuong(A._size);
			for (int i = 0; i < A._size; i++)
			{
				for (int k = 0; k < A._size; k++)
				{
					C.element[i][k] = A.element[i][k] / B.element[i][k];
				}
			}
			return C;
		}
	}

	public static void getCofactor(MaTranVuong A, MaTranVuong temp, int p,int q,int n)
    {
        int i = 0, j = 0;
 
        // Looping for each element of
        // the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
 
                // Copying into temporary matrix
                // only those element which are
                // not in given row and column
                if (row != p && col != q) {
                    temp.element[i][j++] = A.element[row][col];
 
                    // Row is filled, so increase
                    // row index and reset col
                    // index
                    if (j == n - 1) {
                        j = 0;
                        i++;
                    }
                }
            }
        }
    }

	/* Recursive function for
       finding determinant
       of matrix. n is current
       dimension of mat[][]. */
    public static int determinantOfMatrix(MaTranVuong A, int n)
    {
        int D = 0; // Initialize result
 
        // Base case : if matrix
        // contains single
        // element
        if (n == 1)
            return A.element[0][0];
 
        // To store cofactors
        MaTranVuong temp = new MaTranVuong(n);
 
        // To store sign multiplier
        int sign = 1;
 
        // Iterate for each element
        // of first row
        for (int f = 0; f < n; f++)
        {
            // Getting Cofactor of mat[0][f]
            getCofactor(A, temp, 0, f, n);
            D += sign * A.element[0][f] * determinantOfMatrix(temp,n-1);
 
            // terms are to be added with
            // alternate sign
            sign = -sign;
        }
        return D;
    }

	public static explicit operator int(MaTranVuong A)
	{
		return determinantOfMatrix(A,A._size);
	}
}

class Program
{
	static void Main(string[] args) 
	{
		MaTranVuong A = new MaTranVuong(2);
		A.inputMatrix();
		Console.WriteLine("A = \n{0}",A.Info);

		MaTranVuong B = new MaTranVuong(2);
		B.inputMatrix();
		Console.WriteLine("B = \n{0}",B.Info);
		
		MaTranVuong C = A + B;
		Console.WriteLine("A + B = \n{0}",C.Info);

		MaTranVuong D = A - B;
		Console.WriteLine("A - B = \n{0}",D.Info);

		MaTranVuong E = A * B;
		Console.WriteLine("A * B = \n{0}",E.Info);

		MaTranVuong F = A / B;
		Console.WriteLine("A / B = \n{0}",F.Info);

		Console.WriteLine("Det Matrix = {0}",(int)A);
	}
}