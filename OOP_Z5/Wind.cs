using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Z5
{
    class Wind
    {
        double _x;
        double _y;

        public Wind()
        {
        }

        public Wind(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetX()
        {
            return _x;
        }

        public double GetY()
        {
            return _y;
        }
    }
}
