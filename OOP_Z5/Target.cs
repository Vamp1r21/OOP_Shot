using System;
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

        public string Shot(Wind wind, Sustainability sustainability, Shot shot)
        {
            double x = SumPoint(wind.GetX(), shot.GetX(), sustainability.GetX());
            double y = SumPoint(wind.GetY(), shot.GetY(), sustainability.GetY());
            if(x==_x && y==_y)
            {
                return "Вы попали в мишень";
            }
            else
            {
                return "Вы не попали в мишень";
            }
        }

        double SumPoint(double pointOne, double pointTwo, double pointThree)
        {
            return pointOne+pointTwo+pointThree;
        }
        public void PrintTarget()
        {
            Console.WriteLine($"x:{_x}  y:{_y}");
        }
    }
}
