using System;

namespace laba1zvezda
{
	class MainClass
	{
		private static int a1;
		private static int a2;
		private static int a3;
		
		public static void Main (string[] args)
		{
			string buf;
			Console.WriteLine("Введите a1");
			buf=Console.ReadLine();
			if(buf=="")
			{
				Console.WriteLine("ERROR");
				Environment.Exit(1);
			}
			else
			try
			{
				a1=Int16.Parse(buf);
			}
			catch(FormatException e)
			{
				Console.WriteLine("Не верный формат! \r\n" + e.ToString());
				Environment.Exit(1);
			}
			
			Console.WriteLine("Введите a2");
			buf=Console.ReadLine();
			if(buf=="")
			{
				Console.WriteLine("ERROR");
				Environment.Exit(1);
			}
			else
			try
			{
				a2=Int16.Parse(buf);
			}
			catch(FormatException e)
			{
				Console.WriteLine("Не верный формат! \r\n" + e.ToString());
				Environment.Exit(1);
			}
			
			Console.WriteLine("Введите a3");
			buf=Console.ReadLine();
			if(buf=="")
			{
				Console.WriteLine("ERROR");
				Environment.Exit(1);
			}
			else
			try
			{
				a3=Int16.Parse(buf);
			}
			catch(FormatException e)
			{
				Console.WriteLine("Не верный формат! \r\n" + e.ToString());
				Environment.Exit(1);
			}
			
			if(GetChet(a1)&&GetChet(a2)&&GetChet(a3))
				Console.WriteLine("Все числа четные!");
			else 
				Console.WriteLine("Один из чисел не четное!");
				
			
			
			
		}
		
		public static bool GetChet(int i)
		{
			if(i%2==0)
				return true;
			else
				return false;
		}
	}
}

