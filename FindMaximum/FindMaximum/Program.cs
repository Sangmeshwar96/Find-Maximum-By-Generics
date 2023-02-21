using FindMaximum;
using System;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Program To Find The Maximum Values\n");
            FindMax.MaxInt(20, 25, 26); //Int values
            FindMax.MaxFloat(20.86f, 25.26f, 26.256f); //float values
            FindMax.MaxString("Amar", "Vaibhav", "Shiv"); //string values
        }
    }
}