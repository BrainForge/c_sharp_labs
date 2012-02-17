using System;

namespace ConsoleApplicationl 
{     
class Classl
{     
	static double x;
	static double a;
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
	Console.WriteLine("Введите alfa");
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

	double y = Math.Sqrt(Math.PI*x)- Math.Exp(0.2*Math.Sqrt(a))+ 2*Math.Tan(2*a)+
		    1.6e3*Math.Log10(Math.Pow(x,2));
	Console.WriteLine("Для х= {0} и alfa ={1}", x,a);
	Console.WriteLine("Результат =" +y); 
		}
	}
}