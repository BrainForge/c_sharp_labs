using System;

namespace vesna_laba10
{
	public class triangle
	{
		private int mx;
		private int my;
		
		public int x {get{return mx;}set{mx = value;}}
		public int y {get{return my;}set{my = value;}}
		
		public triangle ()
		{
			
		}
		
		public static int operator +(triangle first, triangle second)
        {
                return first.x + second.x;
        }
		
		public static triangle operator --(triangle first)
        {
                return first;
        }
	}
}

