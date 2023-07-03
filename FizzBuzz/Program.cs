using System;


public class NameSpace

   
{

    public string FizzBuzz(int num)
    {
        var answer = "";

        if (num % 3 == 0)
        {
            answer = "fizz";
        }
        if (num % 5 == 0)
        {
            answer = "buzz";
        }
        else if (num % 3 == 0 || num % 5 == 0)
        {
            answer = "fizzbuzz";
        }
        else
        {
            answer = "nothing here";
        }


        return answer;

    }

    public static void Main(string[] args)
    {
        NameSpace how = new NameSpace();

        string result = how.FizzBuzz(105);

        Console.WriteLine(result);
    }

}






