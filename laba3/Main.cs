using System;

namespace laba3
{
	class MainClass
	{
		public static double xn = 0;
		public static double xk = 1.0;
		public static double xh = 0;
		public static bool exit = false;
 		public static void Main (string[] args)
		{
			do
			{
			Console.WriteLine("\n1 - for \n2 - while \n3 do while\n4 - exit");
			try
			{
			switch(Int16.Parse(Console.ReadLine()))
			{
				case 1:
				Console.WriteLine("for!");
				int i = (int)(1/Geth());
				xh = Geth();
				for(int h = 0;h<i;h++)
				{
					Console.WriteLine(Math.Sin(xh));
					xh = xh + Geth();
				}
					break;
				
				case 2:
				Console.WriteLine("while");
					xh = Geth();
					while(xh<1)
					{
						Console.WriteLine(Math.Sin(xh));
						xh = xh + Geth();
					}
					
					break;
				case 3:
				Console.WriteLine("do while");
					xh = Geth();
					do
					{
						Console.WriteLine(Math.Sin(xh));
						xh = xh + Geth();
					}
					while(xh<1);
					break;
					
				case 4:
					Console.WriteLine("bb");
						exit=true;
					Environment.Exit(1);
						
					break;
					
				default:
					Console.WriteLine("input 1,2,3,4");
					break;
			}
			}
			catch(FormatException e)
			{
				Console.WriteLine("FormatException!\n {0}",e);
			}
			}
			while(!exit);
		}
		
		public static double Geth()
		{
			return (xk-xn)/10;
		}
	}
}

