using System;

namespace graph2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Input X ");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine ("Input Y ");
			int y = Int32.Parse(Console.ReadLine());
			Console.WriteLine ("Input R ");
			int r = Int32.Parse(Console.ReadLine());
			
			if(x*x+y<r*r||(x>0 && y >0))
			{
				Console.WriteLine("okai");
			}
			
			
		}
	}
}

