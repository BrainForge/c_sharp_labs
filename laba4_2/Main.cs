using System;

namespace laba4_2
{
	class MainClass
	{
		public static int[] mas = new int[0];		
		public static int sum = 0;
		
		public static void Main (string[] args)
		{
			int i = 0;
			Console.WriteLine("Input array, q - exit, a - add to array");
			
			while(true)
			{
				Console.Write("add to array ");
				string str = Console.ReadLine();
				if(str=="q")
					break;
				else
				{
					try
					{
						IncreaseLength(ref mas);
						mas[i] = Int16.Parse(str);
					}
					catch(FormatException e)
					{
						Console.WriteLine("Write again");
					}
				}
				i++;
			}
			
			Console.WriteLine("Source array: ");
			int max = 0;
			int min = 100;
			int n = 0;
			int maxc = 0;
			int minc = 0;
			foreach(int c in mas)
			{
				Console.Write(c+" ");
				
				if(c>max)
				{
					max = c;
					maxc=n;
				}
				if(c<min)
				{
					min = c;
					minc= n; 
				}
				n++;	
			}
			
			Console.WriteLine("\nmax index = {0}, min index = {1}",maxc,minc);
			
			for(int c = minc;c<=maxc;c++)
				sum = sum + mas[c];

			Console.WriteLine("\nmax = {0}, min = {1}",max,min);
			Console.WriteLine("\nsumm = {0}",sum);
		}
		
		public static void IncreaseLength(ref int[] arr)
        {
            int[] tmp = new int[arr.Length + 1];
            Array.Copy(arr, 0, tmp, 0, arr.Length);
            arr = tmp;
        }
	}
}

