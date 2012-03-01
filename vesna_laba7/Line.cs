using System;

namespace vesna_laba7
{
	public class Line : IFigure
	{
		int _x1;
		int _x2;
		int _y1;
		int _y2;
		
		public int x1 {get{ return _x1;} set{_x1 = value;}}
		public int x2 {get{ return _x2;} set{_x2 = value;}}
		public int y1 {get{ return _y1;} set{_y1 = value;}}
	 	public int y2 {get{ return _y2;} set{_y2 = value;}}
		
		public cord sumVect()
		{
			cord c;
			c.x = _x2-_x2;
			c.y = _y2-_y1;
			return c;
		}
		
		public Line (int x1,int y1,int x2, int y2)
		{
			this._x1 = x1;
			this._x2 = x2;
			this._y1 = y1;
			this._y2 = y2;
		}
	}
}

