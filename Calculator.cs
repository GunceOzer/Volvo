namespace CalculatorApp;

using System.Numerics;

public class Calculator
{
    // it takes an array of integers return sum of them
    public int Addition(int[] arr)
    {
        return arr[0] + arr[1];
    }
    

    // it takes an array of integers and returns their product
    public int Multiplication(int[] arr)
    {
        return arr[0] * arr[1];
    }

    // it takes an array of integers and returns the division
    public double Division(int[] arr)
    {
        if (arr[1] == 0)
        {
            throw new Exception("You can't divide a number with 0");
        }
        return (double)arr[0]/ arr[1];
    }
    

    // it takes an array of integers and returns the difference
    public int Substraction(int[] arr)
    {
        return arr[0]-arr[1];
    }

    // it takes an array of integers and returns the exponentiation
    public int Exponentiation(int[] arr)
    {
        if (arr[1] < 0)
        {
            throw new Exception("Exponent can't be negative value");
        }
        return (int)Math.Pow(arr[0],arr[1]);
    }

    
    // to be able to get bigger results of the factorial I used BigInteger
    // it takes the integer that I've created in the program.cs called forFactorial (which holds the array[0])
    // and returns the factorial of that number
    public BigInteger Factorial(int num) // this is a recursive function for factorial
    {
        if (num < 0)
        {
            throw new Exception("There is no factorial for negative values");
        }
        if (num == 0 || num == 1) // if the number is 0 or 1 return 1
        {
            return 1;
        }

        return num * Factorial(num - 1); 
    }

}