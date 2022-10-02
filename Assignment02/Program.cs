using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;

            do
            {
                Console.WriteLine("Please enter Length of a Rectangle");
                int.TryParse(Console.ReadLine(), out length);

                if (length == 0)
                {
                    Console.WriteLine("Invalid Length Entered, Please enter again!!!");
                }
            } while (length == 0);


            do
            {
                Console.WriteLine("Please enter Width of a Rectangle");
                int.TryParse(Console.ReadLine(), out width);

                if (width == 0)
                {
                    Console.WriteLine("Invalid Width Entered, Please enter again!!!");
                }
            } while (width == 0);


            Rectangle rectangle = new Rectangle(width, length);

            bool exit = false;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("".PadLeft(20, '-'));
                Console.WriteLine("Rectangle Menu".PadLeft(16));
                Console.WriteLine("".PadLeft(20, '-'));
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                Console.Write("Please Choose your option: ");
                int.TryParse(Console.ReadLine(), out var option);

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Rectangle Length: {rectangle.GetCurrentLength()}");
                        break;
                    case 2:
                        int newLength;

                        do
                        {
                            Console.WriteLine("Please enter new Length of a Rectangle");
                            int.TryParse(Console.ReadLine(), out newLength);

                            if (newLength < 1)
                            {
                                Console.WriteLine("Invalid Length Entered, Please enter again!!!");
                            }
                            else
                            {
                                rectangle.SetNewLength(newLength);
                                Console.WriteLine("Successfully Saved new length of rectangle");
                            }
                        } while (newLength < 1);
                        break;
                    case 3:
                        Console.WriteLine($"Rectangle Width: {rectangle.GetCurrentWidth()}");
                        break;
                    case 4:
                        int newWidth;
                        do
                        {
                            Console.WriteLine("Please enter new Width of a Rectangle");
                            int.TryParse(Console.ReadLine(), out newWidth);

                            if (newWidth < 1)
                            {
                                Console.WriteLine("Invalid Width Entered, Please enter again!!!");

                            }
                            else
                            {
                                rectangle.SetNewWidth(newWidth);
                                Console.WriteLine("Successfully Saved new width of rectangle");
                            }
                        } while (newWidth < 1);
                        break;
                    case 5:
                        Console.WriteLine($"\nRectangle Perimeter: {rectangle.GetPerimeter()}");
                        break;
                    case 6:
                        Console.WriteLine($"\nRectangle Area: {rectangle.GetArea()}");
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Option selected !!! Please Choose your option again!!!");
                        break;
                }

            } while (!exit);

        }
    }
}
