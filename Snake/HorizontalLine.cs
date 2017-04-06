using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine( int xleft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xleft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

            /*
            Point p1 = new Point(1, 4, '*');
            Point p2 = new Point(5, 5, '#');
            Point p3 = new Point(1, 7, '%');
            pList.Add( p1 );
            pList.Add( p2 );
            pList.Add( p3 );
            */
        }
    }
}
