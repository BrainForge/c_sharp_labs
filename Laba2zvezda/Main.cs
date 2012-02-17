using System;

namespace Laba2zvezda
{
	class MainClass
	{
		private static int number1 = 0;
		private static string str1;
		
		public static void Main (string[] args)
		{
			try
			{
				str1 = Console.ReadLine();
				if(str1=="")
				{
					Console.WriteLine("null string");
					Environment.Exit(1);
				}
				else
					for(int i = str1.Length;i>=0;i--)
					{
					try
					{
						Console.Write(str1[i]);
					}
					catch(IndexOutOfRangeException e)
					{
						Console.WriteLine();
					}
					}
			}
			catch(FormatException e)
			{
				Console.WriteLine(e);
			}
			
		}
	}
}

