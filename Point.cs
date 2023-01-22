using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form4
{
    class Point
    {
        private double x;
        private double y;
        public double X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public double Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public static double calculatedistance(double x1,double y1,double x2,double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
