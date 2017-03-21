using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;
        //Задание конструкторов (пустой и с 3-мя параметрами).
        public Point()
        {
            Console.WriteLine("Инициализация точки без параметров.");
        }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            symbol = _sym;
        }
                
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
