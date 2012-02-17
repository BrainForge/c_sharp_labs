using System;

namespace laba42
{
	class MainClass
	{
		
		public static int sumotr = 0;
		public static int sumapol = 0;
		
		public static void Main (string[] args)
		{
			Console.WriteLine("Input i");
			int i = Int16.Parse(Console.ReadLine());
			Console.WriteLine("Input j");
			int j = Int16.Parse(Console.ReadLine());
			int[,] mas = new int[i,j];
			Random rand = new Random();
			
			for(int ii = 0; ii < i;ii++)
			{
				for(int ij = 0;ij<j;ij++)
				{
					mas.SetValue(rand.Next(-9,9),ii,ij);
				}
			}
			
			for(int ii = 0; ii < i;ii++)
			{
				for(int ij = 0;ij<j;ij++)
				{
					Console.Write("{0} ",mas.GetValue(ii,ij));
				}
				Console.WriteLine();
			}
			
			for(int ii = 0; ii < i;ii++)
			{
				for(int ij = 0;ij<j;ij++)
				{
					if((int)mas.GetValue(ii,ij)>0)
						sumapol = sumapol + (int)mas.GetValue(ii,ij);
					else
						sumotr = sumotr + (int)mas.GetValue(ii,ij);
				}
			}
				Console.WriteLine("\nsumm otr = {0}\nsumm pol = {1}",sumotr,sumapol);
		}
	}
}

