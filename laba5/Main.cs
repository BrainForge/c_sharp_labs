using System;
using System.Text;

namespace laba5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.WriteLine ("input count char of string ");
			int n = Int16.Parse(Console.ReadLine());
			string str = "";
			Console.WriteLine("input one char");
			String ch1 = Console.ReadLine();
			Console.WriteLine("input two char");
			String ch2 = Console.ReadLine();
			Console.WriteLine("-------------------");
			//string
			for(int i = 0; i<n;i++)
				if((i%2)==0)
					str += ch1;
				else
					str += ch2;
			Console.WriteLine(str);
			Console.WriteLine("-------------------");
			
			char ch0 = ch1[0];
			char ch01 = ch2[0];
			
			char[] maschar = new char[n];
			
			//char
			for(int i = 0; i<n;i++)
				if((i%2)==0)
					maschar[i] = ch0;
				else
					maschar[i] = ch01;
			foreach(char c in maschar)
			{
				Console.Write(c);
			}
			
			Console.WriteLine("\n-------------------");
			
			StringBuilder MyStringBuilder = new StringBuilder();
			
			for(int i = 0; i<n;i++)
				if((i%2)==0)
					MyStringBuilder.Append(ch0);
				else
					MyStringBuilder.Append(ch01);
			
			Console.WriteLine(MyStringBuilder);
			
			Console.WriteLine("-------------------");}
}

		
}

