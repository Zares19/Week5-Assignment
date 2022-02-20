using System;

namespace Week5_Assignment
{
    class Program
    {
        static public void Main(string[] args)
        {
            int N = 100;
            int I = 0;
            int T = 0;

            ProblemOne(N);
            ProblemTwo(I);
            ProblemThree(T);
        }

        static void ProblemOne(int N)
        {
            Console.WriteLine("Numbers between 1 and 100 that can be divided by 3: ");
            for (int num = 1; num <= N; num++)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num + " ");
                }
            }
            
        }

        static void ProblemTwo(int I)
        {
            
            while (true)
            {
                Console.WriteLine("Enter a number, or ok when your done with entering all your numbers: ");
                var input = Console.ReadLine();

                if (input == "ok")
                    break;

                var number = Convert.ToInt32(input);

                I += number;
            }

            Console.WriteLine("Sum of all the numbers is: {0}", I);
        }

        static void ProblemThree(int T)
        {
            Console.WriteLine("Type in the number to find it's factorial: ");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", n, Factorial(n));

             static int Factorial(int n)
            {
                if (n == 0 || n == 1)
                    return 1;

                return n * Factorial(n - 1);
            }
        }
    }
}
    
