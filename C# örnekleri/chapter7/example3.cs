// Fig. 7.17: FactorialTest.cs
// Recursive Factorial method.
using System;

class FactorialTest
{
    static void Main()
    {
        // calculate the factorials of 0 through 10
        for (long counter = 0; counter <= 10; ++counter)
        {
            Console.WriteLine($"{counter}! = {Factorial(counter)}");
        }
    }

    // recursive declaration of method Factorial  
    static long Factorial(long number)
    {
        // base case                               
        if (number <= 1)
        {
            return 1;
        }
        else // recursion step 
        {
            return number * Factorial(number - 1);
        }
    }
}