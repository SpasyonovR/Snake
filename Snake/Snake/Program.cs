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
            Point p1=new Point();
            p1.x = 1;
            p1.y = 3;
            p1.symbol = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 8;
            p2.symbol = '#';
            p2.Draw();
           
            /*int x1 = 1;
            int y1 = 3;
            char symbol1 = '*';

            Draw(x1, y1, symbol1);

            int x2 = 5;
            int y2 = 8;
            char symbol2 = '#';

            Draw(x2, y2, symbol2);*/

            Console.ReadLine();
        }

        /*static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }*/
    }
}
