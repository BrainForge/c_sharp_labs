using System;

namespace laba4
{
	class MainClass
	{
		public static int[] mas = new int[0];
		
		public static int sumotr = 0;
		public static int sumapol = 0;
		
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
			foreach(int c in mas)
			{
				Console.Write(c+" ");
				if(c>0) 
					sumapol = sumapol + c;
				else 
					sumotr = sumotr + c;
			}
			Console.WriteLine("\nsumm otr = {0}\nsumm pol = {1}",sumotr,sumapol);
		}
		
		public static void IncreaseLength(ref int[] arr)
        {
            int[] tmp = new int[arr.Length + 1];
            Array.Copy(arr, 0, tmp, 0, arr.Length);
            arr = tmp;
        }
	}
}

