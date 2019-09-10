using System;

namespace ClassSol1
{
    class Program
    {

        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the years of experience you have in professional programming:");
            year = Convert.ToInt32(Console.ReadLine());
            switch (year)
            {
                case (0):
                    Console.WriteLine("Need a lots of practise");
                    break;
                case (1):
                    Console.WriteLine("Looks like you have a little experience");
                    break;
                default:
                    Console.WriteLine("You are an expert");
                    break;
            }
        }
    }
}
