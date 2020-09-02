using System;
using System.Collections.Generic;
using System.Globalization;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            var iters = 0;

            //Create a variable of type int and initialize the variable with a value of 0

            // Create a do-while loop
            do
            {
                iters++;
                numbers.Add(iters);

            }
            while (iters < 100);



            // Create a while loop
            // While your variable is less than 200
            while (iters < 200)
            {
                iters++;
                numbers.Add(iters);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var number in numbers)
            {
                Console.WriteLine(iters);
            }
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(numbers.Count);
        }
    }
}
