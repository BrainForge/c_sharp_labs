using System;

namespace Laba2
{
	class MainClass
	{
		private static int X = 0;
		private static double znamen = 0;
		private static double otvet;
		public static void Main (string[] args)
		{
			Console.WriteLine ("Input X ");
			
			try
			{
				string str1 = Console.ReadLine();
				if(str1=="")
				{
					Console.WriteLine("null string");
					Environment.Exit(1);
				}
				else
					X = Int32.Parse(str1);
			}
			catch(FormatException e)
			{
				Console.WriteLine(e);
			}
			
				znamen = 2*Math.Pow(X,3)+1;
				if(znamen == 0)
				{
					Console.WriteLine("mul 0!");
					Environment.Exit(1);
				}
				else
				{
					otvet = (Math.Pow(X,2)-5*Math.Sqrt(2))/
						znamen;
					Console.WriteLine("Answer = {0}",otvet);
				}
			
			
		}
	}
}

