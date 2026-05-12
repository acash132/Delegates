//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Delegates
//{
//    internal class Delegate1
//    {
//        public delegate void Calc();

//        static void add()
//        {
//            Console.WriteLine("Enter first number");
//            int a=int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter second number");
//            int b=int.Parse(Console.ReadLine());
//            int result = a + b;
//            Console.WriteLine("The sum is: " + result);
//        }
//        static void sub()
//        {
//            Console.WriteLine("Enter first number");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter second number");
//            int b = int.Parse(Console.ReadLine());
//            int result = a - b;
//            Console.WriteLine("The difference is: " + result);
//        }
//        static void mul()
//        {
//            Console.WriteLine("Enter first number");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter second number");
//            int b = int.Parse(Console.ReadLine());
//            int result = a * b;
//            Console.WriteLine("The product is: " + result);
//        } 
//        public static void div() 
//        {    
//            Console.WriteLine("Enter first number");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter second number");
//            int b = int.Parse(Console.ReadLine());
//            if (b != 0)
//            {
//                int result = a / b;
//                Console.WriteLine("The quotient is: " + result);
//            }
//            else
//            {
//                Console.WriteLine("Cannot divide by zero.");
//            }
//        }

//        static void Main(string[] args)
//        {
//            Calc c;
//            c= add;
//            c();
//            c=sub;
//            c();
//            c=mul;
//            c();
//            c=div;
//            c();


//        }
//    }
//}
