using System;

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {

            Console.Write("Até Qual Numero vai ser testado se 'FizBuzz'?: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int i = 1; i <= n; i++)
            {
                Result.fizzBuzz(i);
            }
        }
    }


    class Result {

        /*
         * Complete the 'fizzBuzz' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void fizzBuzz(int n)
        {

            bool isDivisibleBy3 = n % 3 == 0;
            bool isDivisibleBy5 = n % 5 == 0;
            if (isDivisibleBy3 && isDivisibleBy5)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (isDivisibleBy3)
            {
                Console.WriteLine("Fizz");
            }
            else if (isDivisibleBy5)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(n);
            }
        }

    }
}



