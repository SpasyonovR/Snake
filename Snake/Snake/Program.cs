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
            //Прорисовка рамки.
            Console.SetBufferSize(80, 25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.DrawLine();
            downLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            //Вывлд произвольных точек.
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(5, 8, '#');
            p2.Draw();
            Point p3 = new Point(2, 4, '%');
            p3.Draw();
            Point p4 = new Point(15, 8, '$');
            p4.Draw();

            Console.ReadLine();
        }
    }
}
