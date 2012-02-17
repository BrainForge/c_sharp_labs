using System;

namespace vesna_laba1
{
	class MainClass
	{
	
		
		public static void Main (string[] ags)
		{
			person[] friend = new person[5];
			string name;
			int age;
			
			for(int i = 0;i<5;i++)
			{
				Console.WriteLine("input name");
				name = Console.ReadLine();
				Console.WriteLine("input age");
				age = Int16.Parse(Console.ReadLine());
				friend[i] = new person(name,age);
				Console.WriteLine("new object " + friend[i].mName + " " + friend[i].mAge);	
			}
			
			
			foreach(person pers in friend)
			{
				Console.WriteLine(pers.mName+" "+pers.mAge);	
			}
		}
	}
}
