using System;

namespace vesna_laba8
{
	public class cow : Animal
	{
		private string[] ind = new string[3] {"index 1"," index 2"," index 3"};
		public cow (string name, int age, float mass)
		{
			this.name = name;
			this.age = age;
			this.mass = mass;
		}
		
		public string this[int index]
		{
			get
			{
				return ind[index];
			}
			set
			{
				ind[index] = value;
			}
		}
		
		public void muuu(){ Console.WriteLine("муууу!"); }
		public override string ToString ()
		{
			return "[корова]; зовут "+ name+ "; " + age +" лет;" + " весит "+ mass;
		}
	}
}

