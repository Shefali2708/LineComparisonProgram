using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");

            //UC1
            //LineUC1 LineUC1 = new LineUC1();
            //LineUC1.Values();
            // double length = LineUC1.GetLength();
            //Console.WriteLine("Length of first Line according to points is= " + length);
            //Console.ReadLine();

            //UC2
            //two lines are the equal.
            Console.WriteLine("Welcome to Line Comparison Computation program on Master Branch");
            LineUC2 firstLine = new LineUC2();
            LineUC2 secondLine = new LineUC2();
            firstLine.Values();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line: " + firstLineLength);
            secondLine.Values();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line: " + secondLineLength);

            bool status = LengthComparison(firstLineLength, secondLineLength);
            if (status)
            {
                Console.WriteLine("Both the Line lengths are Equal");
            }
            else
            {
                Console.WriteLine("Line Lengths are not Equal");
            }
        }

        public static Boolean LengthComparison(double firstLength, double secondLength)
        {
            return firstLength.Equals(secondLength);
        }
    }
}
