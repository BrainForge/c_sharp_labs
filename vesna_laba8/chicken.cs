using System;

namespace vesna_laba8
{
	public class chicken : Animal
	{
		public chicken (string name, int age, float mass)
		{
			this.name = name;
			this.age = age;
			this.mass = mass;
		}
		
		public void kudah(){ Console.WriteLine("кудах!"); }
		public override string ToString ()
		{
			return "[курица]; зовут "+ name+ "; " + age +" лет;" + " весит "+ mass;
		}
	}
}

