using System;

namespace laba1dom
{
	class MainClass
	{
	static double x;
	static double a;
	static double z = 3.5e-2;
	static void Main()
	{ 
	string buf;

	Console.Title = "Laba 1";
	Console.WriteLine("Введите x");
	buf=Console.ReadLine();
			if(buf=="")
			{
				Console.WriteLine("ERROR");
				Environment.Exit(1);
			}
			else
			try
			{
				x=Convert.ToDouble(buf);
			}
			catch(FormatException e)
			{
				Console.WriteLine("Не верный формат! \r\n" + e.ToString());
				Environment.Exit(1);
			}
	Console.WriteLine("Введите y");
	buf=Console.ReadLine();
			if(buf=="")
			{
				Console.WriteLine("ERROR");
				Environment.Exit(1);
			}
			else
			try
			{
				a =double.Parse(buf);
			}
			catch(FormatException e)
			{
				Console.WriteLine("Не верный формат! \r\n"  + e.ToString());
				Environment.Exit(1);
			}
			
	Console.WriteLine("Введите z");
	buf=Console.ReadLine();
			if(buf=="")
			{
				Console.WriteLine("ERROR");
				Environment.Exit(1);
			}
			else
			try
			{
				z =double.Parse(buf);
			}
			catch(FormatException e)
			{
				Console.WriteLine("Не верный формат! \r\n"  + e.ToString());
				Environment.Exit(1);
			}

		double t = ((2*Math.Cos(x-Math.PI/6))
				/(0.5+Math.Pow(Math.Sin(a),2)))*
				(1+Math.Pow(z,2)/3-Math.Pow(z,2)/5);
			
	Console.WriteLine("x = "+x + " y = "+a + " z = " + z);
	Console.WriteLine("Результат = " + Math.Round(t,6)); 
		}
	}
}

