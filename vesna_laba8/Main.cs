using System;
using System.Collections;

namespace vesna_laba8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ArrayList list = new ArrayList();
			Dog[] mas = new Dog[1];
			
			Dog dog1 = new Dog("no name 0",12,0.1f);
			
			list.Add(dog1);
			list.Add(new chicken("no name 1",2,0.4f));
			list.Add(new Dog("no name 2",1,0.1f));
			mas[0] = dog1;
			
			foreach(Dog d in list)
			{
					list.Remove(d);
					Console.WriteLine("{0} - убит",d.name);
					break;
			}
			
			cow[] muMas = new cow[3];
			muMas[0] = new cow("no name 3",13,0.1f);
			muMas[1] = new cow("no name 4",3,0.2f);
			muMas[2] = new cow("no name 5",11,0.4f);
			
			list.Add(muMas);
				
			foreach(object d in list)
			{
				Console.WriteLine(d.ToString());
				if(d.Equals(muMas))
					foreach(cow c in muMas)
						Console.WriteLine(c.ToString()+"; индексатор "+c[0]);
				
				
			}
		}
	}
}
