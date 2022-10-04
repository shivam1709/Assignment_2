using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;
            bool exit = false;
            String selectedOption;
            do
            {
                Console.Write("Enter the length of the Rectangle: ");
                try
                {
                    length = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Enter only integers");
                }
                
                if (length <= 0)
                {
                
                    Console.WriteLine("Incorrect Input!");
                }
            } while (length <= 0);
            do
            {
                Console.Write("Enter the width of the Rectangle: ");
                try
                {
                    width = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Enter only integers");
                }
                if (width <= 0)
                {

                    Console.WriteLine("Incorrect Input!");
                }
            } while (width <= 0);
            Rectangle rectangle = new Rectangle(length,width);
            do
            {
                Console.WriteLine("".PadRight(70, '_'));
                Console.WriteLine("Menu");
                Console.WriteLine("".PadRight(70, '_'));
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                selectedOption = Console.ReadLine();
                Console.WriteLine("".PadRight(70, '_'));
                switch (selectedOption)
                {
                    case "1":
                        Console.Write($"Current length of the Rectangle = {rectangle.GetCurrentLength()}");
                        break;
                    case "2":
                        Console.Write("Enter the new length for the Rectangle : ");
                        length = int.Parse(Console.ReadLine());
                        if(length > 0)
                        {
                            rectangle.SetNewLength(length);
                        }
                        else
                        {
                            Console.WriteLine("Length cannot be less than 1");
                        }
                        break;
                    case "3":
                        Console.Write($"Current width of the Recttangle = {rectangle.GetCurrentWidth()}");
                        break;
                    case "4":
                        Console.Write("Enter the new width for the Rectangle : ");
                        width = int.Parse(Console.ReadLine());
                        if (width > 0)
                        {
                            rectangle.SetNewWidth(width);
                        }
                        else
                        {
                            Console.WriteLine("Width cannot be less than 1");
                        }
                        break;
                    case "5":
                        Console.Write($"Perimeter of the Rectangle = {rectangle.GetArea()}");
                        break;
                    case "6":
                        Console.Write($"Area of the Rectangle = {rectangle.GetPerimeter()}");
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect option is selected");
                        break;
                }

                Console.WriteLine();
            } while (!exit);


        }
    }
}