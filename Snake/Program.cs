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
            Console.SetBufferSize(80, 25);

            //Отрисовка рамки
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine RightLine = new VerticalLine(78, 0, 24, '+');
            UpLine.DrawLine();
            DownLine.DrawLine();
            LeftLine.DrawLine();
            RightLine.DrawLine();

            Console.ReadLine();
        }
    }
}
