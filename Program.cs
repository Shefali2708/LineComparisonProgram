using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");

            LineUC1 LineCompUC1 = new LineUC1();
            LineCompUC1.Values();
            double length = LineCompUC1.GetLength();
            Console.WriteLine("Length of first Line according to points is= " + length);
            Console.ReadLine();
        }
    }
}
