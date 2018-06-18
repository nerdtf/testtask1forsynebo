using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Solution
    {
        int a = 0;
        int b = 0;
        public Solution(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int solution()
        {
            int counter = 0;
            double c = 0.0;
            if (this.a < this.b)
            {
                for (int i = this.a; i < this.b; i++)
                {
                    c = Math.Sqrt(i);           
                    if (c - Convert.ToInt32(c) == 0)
                    {
                        counter++;
                    }
                }
                return counter;
            }           
            else{
                Console.WriteLine("A > B");
                System.Environment.Exit(1);
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution g1 = new Solution(4, 17);
            Console.WriteLine(g1.solution());
        }
    }
}