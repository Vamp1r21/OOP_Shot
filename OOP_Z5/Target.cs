﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Z5
{
    class Target
    {
        double _x;
        double _y;

        public Target()
        {
        }

        public Target(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public string Shot(Wind wind, Sustainability sustainability)
        {

            return "";
        }

        public void PrintTarget()
        {
            Console.WriteLine($"x:{_x}  y:{_y}");
        }
    }
}
