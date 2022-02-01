using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intro 
            Console.WriteLine("Hello, this app will help calculate the area, perimeter, volume, and surface area of various rectangular room.");
            Console.WriteLine();

            // getting info 
            Console.WriteLine("Please enter the length of the room: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the room: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the room: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // calculations & display messages
            double area = length * width;
            Console.WriteLine("The area of the room is " + area + ".");
            double perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter of the room is " + perimeter + ".");
            double volume = area * height;
            Console.WriteLine("The volume of the room is " + volume + ".");
            double surfaceArea = 2 * ((width * length) + (height * length) + (height * width));
            Console.WriteLine("The surface area of the room is " + surfaceArea + ".");

            if (area <= 250)
            {
                Console.WriteLine("This is a small sized room.");
            }
            else if(area > 250 && area < 650)
            {
                Console.WriteLine("This is a medium sized room.");
            }
            else if(area >= 650)
            {
                Console.WriteLine("This is a large sized room.");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the room calculator app. Have a nice day.");

        }
    }
}