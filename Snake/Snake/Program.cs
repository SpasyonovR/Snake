using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 8, Direction.RIGHT);
            snake.DrawLine();

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    snake.HandleKey();
                }
                snake.Move();
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
