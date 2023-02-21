using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class FindMax
    {
        public static void MaxInt(int a, int b, int c)
        {
            Console.WriteLine("Maximum Int Value : ");
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
        public static void MaxFloat(float a, float b, float c)
        {
            Console.WriteLine("\nMaximum Float Value : ");
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
        public static void MaxString(string a, string b, string c)
        {
            Console.WriteLine("\nMaximum String Value : ");
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                Console.WriteLine(a + " is Maximum");
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                Console.WriteLine(b + " is Maximum");
            }
            else
            {
                Console.WriteLine(c + " is Maximum");
            }
        }
    }
}