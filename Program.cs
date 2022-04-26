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

            //UC3
            Console.WriteLine("Welcome to Line Comparison Computation program on Master Branch");
            LineUC3 firstLine = new LineUC3();
            LineUC3 secondLine = new LineUC3();
            firstLine.Values();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line: " + firstLineLength);
            secondLine.Values();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line: " + secondLineLength);

            int status = LengthComparison(firstLineLength, secondLineLength);

            if (status > 0)
            {
                Console.WriteLine("Length Of Line First is greater");
            }
            else if (status < 0)
            {
                Console.WriteLine("Length Of Line Second is greater");
            }
            else
            {
                Console.WriteLine("Length Of both Line are Equal");
            }
            Console.ReadLine();
        }

        public static int LengthComparison(double firstLength, double secondLength)
        {
            return firstLength.CompareTo(secondLength);
        }
    }
}
