using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day09
{
    abstract public class Shape
    {
        public abstract void Area();
    }
    public class Rectangle : Shape
    {
        public double length;
        public double breadth, result;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void Area()
        {
            result = length * breadth;
        }
        public override string ToString()
        {
            return $"Area of Rectangle : {result}";
        }
    }
}
