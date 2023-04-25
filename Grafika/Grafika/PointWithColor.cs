﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafika
{
    class PointWithColor
    {
        public Point point { get; set; }
        
        public Color color { get; set; }

    public PointWithColor()
        {

        }
        public PointWithColor(Point p, Color c)
        {
            point = p;
            color = c;
        }

    }
}
