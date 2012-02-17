using System;

namespace struc
{

	public struct Student
	{
		public string name;
		public int number;
		public int [] mas;
		public int id;
		
	}
	
	class MainClass
	{
		
		public enum groups
        {
 	        t994 = 1,
			t991 = 2,
			t993 = 3
        }
		
		private static bool duck = true;
		public static void Main (string[] args)
		{
			Console.WriteLine("welcome to hell");
			Console.WriteLine("input data");
			
			Student[] stud = new Student[10];
			
			for(int i = 0;i<10;i++)
			{
				Console.WriteLine("input {0} student: \r\n",i);
				Console.WriteLine("Name: ");
				stud[i].name = Console.ReadLine();
				
				Console.WriteLine("group: ");
				switch(Console.ReadLine())
				{
				case "t991":
					stud[i].id = (int)groups.t991;
					break;
					
				}
				
				Console.WriteLine("Number: ");
				stud[i].number = int.Parse(Console.ReadLine());
				stud[i].mas = new int[5];
				
				for(int n = 0;n<5;n++)
				{
					stud[i].mas[n] = int.Parse(Console.ReadLine());
				}
			}
			
			Console.WriteLine("Student avg > 4.0");
			
			foreach(Student st in stud)
			{
				float av = avg (st.mas);
				
				if(av>4.0f)
				{
					Console.WriteLine("name: "+st.name);
					Console.WriteLine("number: "+st.number);
					Console.WriteLine("avg = "+av);
					duck = false;
				}
			}
			
			if(duck)
				Console.WriteLine("All avg < 4.0");

			
		}
		
		public static float avg(int[] mas)
		{
			int sum = 0;
			foreach(int i in mas)
			{
				sum+=i;
			}
			
			return sum/5;
		}
	}
}
