using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            this.radius = r;
            this.color = "red";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;

        }
        public string getColor()
        {
            return color;
        }
        public double getRadius()
        {
            return radius;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public void setRadius(double newRadius)
        {
            this.radius = newRadius;
        }
        public void setColor(string newColor)
        {
            this.color = newColor;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius={0},color={1}]", radius, color);
            //return base.ToString();
        }
    }
}