﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void DrawLine()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
