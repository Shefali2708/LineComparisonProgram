using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //statement 
            Console.WriteLine("This is a program for Line Comparison");
            Console.WriteLine("Enter the coordinates for length calculate : ");

            //variable
            double x1, y1, x2, y2, length1;

            Console.WriteLine("enter x1: "); //coordinate
            x1 = Convert.ToDouble(Console.ReadLine()); //convert string to double

            Console.WriteLine("enter y1: ");//coordinate
            y1 = Convert.ToDouble(Console.ReadLine());//convert string to double

            Console.WriteLine("enter x2: ");//coordinate
            x2 = Convert.ToDouble(Console.ReadLine());//convert string to double

            Console.WriteLine("enter y2: ");//coordinate
            y2 = Convert.ToDouble(Console.ReadLine());//convert string to double

            //formula for Question
            length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))); //UC1

            double a1, b1, a2, b2, length2; //UC2

            Console.WriteLine("enter a1: ");//coordinate
            a1 = Convert.ToDouble(Console.ReadLine());//convert string to double

            Console.WriteLine("enter b1: ");//coordinate
            b1 = Convert.ToDouble(Console.ReadLine());//convert string to double

            Console.WriteLine("enter a2: ");//coordinate
            a2 = Convert.ToDouble(Console.ReadLine());//convert string to double

            Console.WriteLine("enter b2: ");//coordinate
            b2 = Convert.ToDouble(Console.ReadLine());//convert string to double

            //formula for Question UC2
            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)));

            //CompareTo method is used for compare 
            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Lines is equal length");
            }

            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line1 is bigger than Line2");
            }
            else
            {
                Console.WriteLine("Line2 is bigger than Line1");
            }
            Console.ReadLine();
        }
    }
}
