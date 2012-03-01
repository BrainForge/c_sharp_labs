using System;

namespace vesna_laba7
{
	public struct cord
	{
		public int x;
		public int y;
	}
	
	public interface IFigure
	{
		int x1 {get;set;}
		int x2 {get;set;}
		int y1 {get;set;}
		int y2 {get;set;}
		cord sumVect();
	}
}

