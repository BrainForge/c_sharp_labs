using System;

namespace vesna_laba7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("input x1,y1,x2,x2");
			Line line = new Line(Int16.Parse(Console.ReadLine()),Int16.Parse(Console.ReadLine()),
			                     Int16.Parse(Console.ReadLine()),Int16.Parse(Console.ReadLine()));
			
			Console.WriteLine("X1={0} Y1={1} X2={2} Y2={3}",line.x1,line.y1,line.x2,line.y2);
			Console.WriteLine("line lenght: X="+line.sumVect().x+"Y="+line.sumVect().y);
		}
	}
}
