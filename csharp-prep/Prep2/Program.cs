using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string strPercent = Console.ReadLine();
        int intPercent = int.Parse(strPercent);
        int intSign = intPercent % 10;

        // Calls the getLetter function and stores the result
        // in the variable 'letter'
        string letter = getLetter(intPercent);

        // Calls the getSign function and stores the result in
        // the variable 'sign'
        string sign = getSign(intSign);

        // This function determines the sign, if any, that
        // goes next to the grade.
        string getSign(int intSign)
        {
            string sign = "";
            if (intSign >= 7)
            {   
                sign = "+";
            }
            else if (intSign <= 3){
                sign = "-";
            }
            return sign;
        }

        // This function determines which grade the student receives,
        // based on the inputted integer.
        string getLetter(int intPercent)
        {   
            string letter = "";
            if (intPercent >= 90)
            {
                letter = "A";
            }
            else if (intPercent >= 80)
            {
                letter = "B";
            }
            else if (intPercent >= 70)
            {
                letter = "C";
            }
            else if (intPercent >= 60)
            {
                letter = "D";
            }
            else 
            {
                letter = "F";
            }
            return letter;
        }

        
        if (letter == "A" && intSign >= 7)
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        if (sign == "")
        {
            Console.WriteLine($"Grade: '{letter}'");
        }
        else{
            Console.WriteLine($"Grade: '{letter}{sign}'");
        }

        if (intPercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else 
        {
            Console.WriteLine(@"You are not able to pass the course YET.
Try again next semester. You can get better!");
        }
    }
}