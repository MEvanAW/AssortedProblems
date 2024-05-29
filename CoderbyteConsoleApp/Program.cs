// https://coderbyte.com/information/First%20Factorial
using System;
using System.Linq;

class MainClass
{

    public static int FirstFactorial(int num)
    {
        int result = Enumerable.Range(1, num).Aggregate((x, y) =>  x * y );
        return result;

    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(FirstFactorial(int.Parse(Console.ReadLine())));

    }

}