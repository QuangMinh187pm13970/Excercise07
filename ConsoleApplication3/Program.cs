using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("the rectangle has length of " + r1.getLength() + " has width of " + r1.getWidth());
            Console.WriteLine(r1.ToString());
            Rectangle r2 = new Rectangle(2.0f,3.0f);
            Console.WriteLine("the rectangle has getarea of " +r2.getArea());
            Rectangle r3 = new Rectangle(2.0f, 3.0f);
            Console.WriteLine("the rectangle has getarea of " + r3.getPerimeter());
        }
    }
}
