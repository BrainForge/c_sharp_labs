using System;

namespace vesna_laba3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("input a ");
			double a = Double.Parse(Console.ReadLine());
			Console.Write("\ninput b ");
			double b = Double.Parse(Console.ReadLine());
			Console.Write("\ninput c ");
			double c = Double.Parse(Console.ReadLine());
			tarakan tar = new tarakan(a,b,c);
			tar.run();
			Console.WriteLine(tar.ToString());
		}
	}
}
