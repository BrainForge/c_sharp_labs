using System;

namespace vesna_laba5
{
	public class X : Y
	{
		private int x1;
		private int x2;
		public X (int x1, int x2, int y)
		{
			this.y = y;
			this.x1 = x1;
			this.x2 = x2;
		}
		
		public override string ToString ()
		{
			return run(this.x1,this.x2).ToString();
		}
	}
}

