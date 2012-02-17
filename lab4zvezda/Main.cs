using System;

namespace lab4zvezda
{
	class MainClass
	{
		public static double rezult = 0;
		public static void Main (string[] args)
		{
			Console.WriteLine("input count poli");
            int n = int.Parse(Console.ReadLine());
			double[] Mas = new double[n];
            
			Console.WriteLine("input poli");
            for (int i = 0; i < n; i++)
            {
                Mas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("input X");
            double x = double.Parse(Console.ReadLine());
            int t = 0;
            for (int i = n-1; i >=0 ; i--,t++)
            {
                rezult += Mas[t] * Math.Pow(x,i);
            }
            Console.WriteLine("rezult = " + rezult);
            Console.ReadKey();
		}
	}
}

