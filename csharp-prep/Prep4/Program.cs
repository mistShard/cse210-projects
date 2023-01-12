using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        float sum = 0;
        List<float> numbers = new List<float>();
        float end = 0;

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        bool check = true;

        while (check)
        {
            Console.Write("Enter a number: ");
            string strNum = Console.ReadLine();
            float num = int.Parse(strNum);

            if (num != end)
            {
                numbers.Add(num);
            }
            else
            {
                check = false;
            }
        }

        float maxNumber = numbers[0];
        List<float> postiveNums = new List<float>();

        foreach (var number in numbers)
        {
            sum += number;
            if (number > maxNumber)
            {
                maxNumber = number;
            }
            if (number > 0)
            {
                postiveNums.Add(number);
            }
        }

        float minPostiveNumber = postiveNums[0];

        foreach(var positveNum in postiveNums)
        {
            if (positveNum < minPostiveNumber)
            {
                minPostiveNumber = positveNum;
            }
        }

        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {minPostiveNumber}");

    }
}