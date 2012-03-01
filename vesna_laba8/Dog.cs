using System;

namespace vesna_laba8
{
	public class Dog : Animal
	{
		public Dog (string name, int age, float mass)
		{
			this.name = name;
			this.age = age;
			this.mass = mass;
		}
		
		public void bark() { Console.WriteLine("гав!"); }
		
		public override string ToString ()
		{
			return "[собако]; зовут "+ name+ "; " + age +" лет;" + " весит "+ mass;
		}
	}
}

