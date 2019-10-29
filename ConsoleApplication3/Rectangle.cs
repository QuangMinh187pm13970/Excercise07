using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Rectangle
    {
        private float length;
        private float width;


        public Rectangle()
        {
            length = 1.0f;
            width = 1.0f;
        }
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;

        }
        public float getLength()
        {
            return length;
        }
        public float getWidth()
        {
            return width;
        }
        public void setLength(float newLength)
        {
            this.length = newLength;
        }
        public void setWidth(float newwidth)
        {
            this.width = newwidth;
        }
        public double getArea()
        {
            double acreage;
            return acreage = (this.length) * (this.width);
        }
        public double getPerimeter()
        {
            double perimeter;
            return perimeter = 2 * ((this.length) + (this.width));

        }
        public override string ToString()
        {
            return String.Format("Rectangle[length={0},width={1}]", length, width);
            //return base.ToString();
        }
    }
}