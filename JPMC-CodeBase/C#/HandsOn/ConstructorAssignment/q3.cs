using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class q3
    {
    }
    class Shapes
    {
        public double radius;
        public double length, breadth;
        public int height, s,side;
        public Shapes()
        {
            radius = 4.0D;
            length = 5.0D;
            breadth = 6.2D;
            side = 3;
            height = 2;
            s = 10;
        }
        public double calculateArea(double radius)
        {
            return 3.14 * radius * radius;
        }
        public double calculateArea(int side)
        {
            return (double)side * (double)side;
        }
        public double calculateArea(double length, double breadth)
        {
            return length * breadth;
        }
        public double calculateArea(int height,int bas)
        {
            return (double)height * (double)bas * 0.5D;
        }
    }
}
