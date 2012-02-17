using System;

namespace Graph
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("input X");
			int X = Int32.Parse(Console.ReadLine());
			double y = 0;
			if(X>=-9.0&&X<-6.0)
			{
				y = Math.Sqrt(Math.Abs(9.0-(X+6.0)*(X+6.0)));
			}
			
			if(X>=-6.0&&X<-3.0)
			{
				y = X +3.0;
			}
			
			if(X>=-3.0&&X<0)
			{
				y = Math.Sqrt(9.0-X*X);
			}
			
			
			if(X>=0&&X<3.0)
			{
				y = 3.0 - X;
			}
			
			if(X>=3.0&&X<9.0)
			{
				y = X - 3/3;
			}
			
			Console.WriteLine("otvet = {0}",y);

			
		}
	}
}

