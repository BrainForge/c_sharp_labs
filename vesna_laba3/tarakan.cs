using System;

namespace vesna_laba3
{
	public class tarakan
	{
		public double x1;
		public double x2;
		
		public double a;
		public double b;
		public double c;
		
		public double D;
		
		public tarakan (double A, double B, double C)
		{
			a = A;
			b = B;
			c = C;
		}
		
		public void run()
		{
			D = Math.Pow(b,2) - 4*a*c;
			
			x1=(-b+Math.Sqrt(D))/(2*a);
			x2=(-b-Math.Sqrt(D))/(2*a);
		}
		
		public override string ToString ()
		{
			return "D="+D+" x1="+x1+" x2"+x2;
		}
	}
}

