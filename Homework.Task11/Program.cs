using System;
using Homework.Task11.Models;
namespace Homework.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //If user 1 writes and clicks enter, Square's CalcArea method should start.
            //If user type 2 and press enter, Rectangular's CalcArea method should start.
            //If the user writes 0 and presses enter, the program should end.
            Square quadratic = new Square(5);
            Rectangular rectangular = new Rectangular(-5, 4);
            int choice;
            do
            {
                Console.WriteLine("Enter");
                Console.WriteLine("---------------");


                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("The program is quit");
                        break;
                    case 1:
                        if (quadratic.Side > 0)
                        {
                            Console.WriteLine("The area of the square" + " " + quadratic.CalcArea());
                        }
                        else
                        {
                            Console.WriteLine("Number is negative");
                        }
                        break;
                    case 2:
                        if (rectangular.Width > 0 && rectangular.Length>0)
                        {
                            Console.WriteLine("The area of a rectangle" + " " + rectangular.CalcArea());
                        }

                        else
                        {
                            Console.WriteLine("Number is negative");
                        }
                        break;
                    default:
                        Console.WriteLine("-------------");
                        break;
                } 
            } while (choice != 0);
        }
    }
}