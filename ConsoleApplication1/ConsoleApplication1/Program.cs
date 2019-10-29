using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int A = 0, B = 100;
            int count = 1;
            while (B > A + 1)
            {
                int C = (A + B) / 2;
                Console.WriteLine("Q {0} is number less than {1}", count, C);
                 answer = Console.ReadLine();
                if (answer == "Y")
                    B = C;
                if (answer == "N")
                    A = C + 1;
                count++;
            }
            Console.Write("is your number {0}", A);
            answer = Console.ReadLine();
            if (answer == "y")
                Console.Write("is your number is {0}", B);
            answer = Console.ReadLine();
            if (answer == "n")
                Console.Write("q{0}is your number is {1}");
        }
    }
}
