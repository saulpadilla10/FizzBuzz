using System;

public class NameSpace
{
    public string FizzBuzz(int num)
    {
        if (num % 3 == 0 && num % 5 == 0)

        {
            return "fizzbuzz";

        }

        else if (num % 3 == 0)
        {
            return "fizz";
        }
        else if (num % 5 == 0)
        {
            return "buzz";
        }

        else
        {
            return "nothing here";

        }
    }

    public static void Main(string[] args)
    {
        NameSpace how = new NameSpace();
        string result = how.FizzBuzz(105);

        Console.WriteLine(result);
    }
}







