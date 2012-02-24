using System;

namespace vesna_laba6
{
	public class Dot : Figura
	{
		
		public Dot(int x,int y)
		{
			this.x = x;
			this.y = y;
		}
		
		public override int getX ()
		{
			base.getX();
			return x;
		}
		
		public override int getY ()
		{
			base.getY();
			return y;
		}
		
		public override string ToString ()
		{
			return "X="+x+" Y="+y;
		}
		
		
	}
}

