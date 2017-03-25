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
            Point p2 = new Point(5, 8, '#');
            p2.Draw();
            Point p3 = new Point(2, 4, '%');
            p3.Draw();
            Point p4 = new Point(15, 8, '$');
            p4.Draw();

            HorizontalLine Line1 = new HorizontalLine(1, 20, 10, '+');
            Line1.DrawLine();
            VerticalLine Line2 = new VerticalLine(10, 20, 1, '+');
            Line2.DrawLine();
            HorizontalLine Line3 = new HorizontalLine(1, 20, 20, '+');
            Line3.DrawLine();
            VerticalLine Line4 = new VerticalLine(10, 20, 20, '+');
            Line4.DrawLine();

            Console.ReadLine();
        }
    }
}
