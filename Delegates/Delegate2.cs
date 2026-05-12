using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegate2
    {
        
        internal class Delegate1
        {
            // Declaring the delegate
            public delegate void Calc();

            static void add()
            {
                Console.WriteLine("\n--- Addition ---");
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The sum is: " + (a + b));
            }

            static void sub()
            {
                Console.WriteLine("\n--- Subtraction ---");
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The difference is: " + (a - b));
            }

            static void mul()
            {
                Console.WriteLine("\n--- Multiplication ---");
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The product is: " + (a * b));
            }

            public static void div()
            {
                Console.WriteLine("\n--- Division ---");
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                if (b != 0)
                    Console.WriteLine("The Division is: " + (a / b));
                else
                    Console.WriteLine("Error: Cannot divide by zero.");
            }

            static void Main(string[] args)
            {
                string choice;
                do
                {
                    
                    Console.WriteLine("Select an Mathematical Operation:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");
                    Console.Write("\nEnter choice (1-4): ");

                    string op = Console.ReadLine();
                    Calc c ; // Creating an Object for the delegate

                    // Assign the method based on user input
                    switch (op)
                    {
                        case "1": 
                            c = add;//Making the delegate point to the add method
                            c();//Executing the method through the delegate
                            break;
                        case "2": 
                            c = sub;//Making the delegate point to the sub method
                            c();//Executing the method through the delegate
                            break;
                        case "3": 
                            c = mul;//Making the delegate point to the mul method
                            c();//Executing the method through the delegate
                            break;
                        case "4": 
                            c = div;//Making the delegate point to the div method
                            c();//Executing the method through the delegate
                            break;
                        default:
                            Console.WriteLine("Invalid selection!");
                            break;
                    }


                    Console.Write("\nDo you want to continue? (yes/no): ");
                    choice = Console.ReadLine().ToLower();

                } while (choice == "yes");

               
            }
        }
    }
}

