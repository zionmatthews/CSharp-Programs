using System;

namespace CSharp_Problem_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
        }

        public static void Problem1()
        {
            /* Write a C# Sharp program to print Hello and your name in a seprate line and write a C#
             * Sharp program to print the sum of two numbers(Take two inputs) */

            Console.WriteLine(" Problem 1");

            //Prints the text onto the console
            Console.WriteLine("\nHello: Zion");
            Console.WriteLine("\nType in a number and hit enter. Then type in a second number and hit enter.");
          
            Console.Write("\nFist Number : " );
             int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number : ");
             int num2 = Convert.ToInt32(Console.ReadLine());          

            // Adding both numbers and printing out the result on console
            double sum = num1 + num2;
            Console.WriteLine("\nResult: " + sum);

            Console.WriteLine("\nPress enter to move on.");
            Console.ReadKey();

            Problem2();
        }

        public static void Problem2()
        {
            /* Write a C# Sharp program to print the result of the
             * specified operations. */

            Console.WriteLine("\n Problem 2");

            Console.WriteLine("\nOperations");
            Console.WriteLine("-1 + 4 * 6");
            Console.WriteLine("(35 + 5) % 7");
            Console.WriteLine("14 + -4 * 6 / 11");
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2");

            Console.WriteLine("\nPress enter to see the results of the specified operations.\n");
           Console.ReadKey();

            // The specified operations 
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            Console.WriteLine("\nPress enter to move on.");
            Console.ReadKey();

            Problem3();
        }

        public static void Problem3()
        {
            // Write a c# sharp program to swap two numbers.

            Console.WriteLine("\nProblem 3 ");

            int num1, num2, temp;

            Console.Write("\nInput the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPress enter to swap numbers");
            Console.ReadKey();

            //swapping integers
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nFirst Number : " + num1);
            Console.WriteLine ("Second Number : " + num2);

            Console.WriteLine("\nPress enter to move on.");
            Console.ReadKey();

            Problem4();
        }

        public static void Problem4()
        {
            /* Write a C# Sharp program that takes a number as input 
             * and print its multiplication table. */

            Console.WriteLine("\nProblem 4");

            int x, result;

            Console.Write("Enter a number to print out its multiplication table: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe multiplication table of : " + x);

            for (int i=0; i<11; i++)
            {
                result = x * i;                
                Console.WriteLine("{0} * {1} = {2}", x, i, result);
            }

            Console.WriteLine("\nPress enter to move on.");
            Console.ReadKey();

            Problem5();
        }

        public static void Problem5()
        {
            // Write a C# program to print the odd and even numbers from 1 to 100

            Console.WriteLine("\nProblem 5");

            Console.WriteLine("Press enter to see all the odd numbers from 1 to 100");
            Console.ReadKey();

            //Prints out all the odd numbers from 1 to 100
            Console.WriteLine("\nOdd numbers from 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Press enter to see all the even numbers from 1 to 100");
            Console.ReadKey();

            //Prints out all the even numbers from 1 to 100
            Console.WriteLine("\nEven numbers from 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }
    }
}
