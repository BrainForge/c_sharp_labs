using System;

namespace laba1Moi
{
class Classl
{     
	static double a;
	static void Main()
	{ 
	string buf;

	Console.Title = "Laba 1";
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
			
			double z1 = 2*Math.Pow(Math.Sin(3*Math.PI-2*a),2)*Math.Pow(Math.Cos(5*Math.PI + 2*a),2);
			double z2 = 0.25 - 0.25*Math.Sin(2.5*Math.PI - 8 * a);
			
			Console.WriteLine("z1 = "+z1 +"\r\nz2 = " + z2);
		}

}

}