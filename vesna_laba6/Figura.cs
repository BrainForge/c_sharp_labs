using System;

namespace vesna_laba6
{
	public abstract class Figura
	{
		public int x;
		public int y;
		public virtual int getX()
		{
			return x;
		}
		public virtual int getY()
		{
			return y;
		}
	}
}

