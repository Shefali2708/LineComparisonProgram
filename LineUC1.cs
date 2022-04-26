using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class LineUC1
    {
        public double x1, y1, x2, y2;
        public void Values()
        {
            //-A Length as 2 Points(x1, y1) and(x2, y2) 
            Console.WriteLine("Enter x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2");
            y2 = Convert.ToDouble(Console.ReadLine());
        }
        public double GetLength()
        {
            //- Length of a Line = sqrt((x2 - x1) ^ 2 + (y2- y1) ^ 2)
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
    }
}
