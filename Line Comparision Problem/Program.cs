using System;

namespace Line_Comparision_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LenghtofLine();
        }
        public static void LenghtofLine()
        {
            Console.WriteLine("Enter First Point");
            Console.WriteLine("X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("........................");
            Console.WriteLine("Enter Second Point");
            Console.WriteLine("X2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("........................");
            double LenghtofLine = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            Console.WriteLine("Lenght of a Line is : {0}",LenghtofLine);
        }
    }
}
