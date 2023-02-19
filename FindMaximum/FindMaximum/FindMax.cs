using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class FindMax
    {
        public void ToCompare(int a, int b, int c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                Console.WriteLine(a+" is Maximum");
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                Console.WriteLine(b+" is Maximum");
            }
            else
            {
                Console.WriteLine(c+" is Maximum");
            }
        }
    }
}