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
            List<int> numList = new List<int>();
            numList.Add(20);
            numList.Add(21);
            numList.Add(22);

            int n0 = numList[0];
            int n1 = numList[1];
            int n2 = numList[2];
            Console.WriteLine("n0=" + n0 + ", n1=" + n1 + ", n2=" + n2);

            numList.RemoveAt(1);
            
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(5, 8, '#');
            Point p3 = new Point(2, 4, '%');
            Point p4 = new Point(15, 8, '$');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            foreach (Point i in pList)
            {
                i.Draw();
            }

            Console.ReadLine();
        }
    }
}
