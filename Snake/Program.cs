using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
           
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine Line1 = new HorizontalLine(5, 10, 3, '♥');
            Line1.DrawLine();

            VerticalLine Line2 = new VerticalLine(15, 3, 7, '♦');
            Line2.DrawLine();

            Console.ReadLine();
        }
    }
}
