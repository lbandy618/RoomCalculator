using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intro 
            Console.WriteLine("Hello, this progam will help calculate the area and perimeter of various rectangular room.");
            Console.WriteLine();
            // getting info 
            Console.WriteLine("Please enter the length of the room: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the room: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine();
            // calculations
            double area = length * width;
            Console.WriteLine("The area of the room is " + area + ".");
            double perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter of the room is " + perimeter + ".");


        }
    }
}