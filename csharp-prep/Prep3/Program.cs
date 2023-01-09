using System;

class Program
{
    static void Main(string[] args)
    {
        int intGuess = 0;
        int count = 0;
        string ans = "";

        void main()
        {
            string finAns = startGame(intGuess, count, ans);

            if (finAns == "yes")
            {
                startGame(intGuess, count, ans);
            }
            else
            {
                Console.WriteLine("Goodbye. Thank you for playing!");
            }
        }

        string startGame(int intGuess, int count, string ans)
        {   
            Random rnd = new Random();
            int num = rnd.Next(2, 101);

            do
            {   
            Console.Write("What is your guess? ");
            string strGuess = Console.ReadLine();
            intGuess = int.Parse(strGuess);

            if (intGuess < num)
            {
                Console.WriteLine("Higher");
            }
            else if (intGuess > num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            count++;
            
            } while (intGuess != num);

        Console.WriteLine($"Tries: {count}");
        Console.WriteLine(""); Console.Write("Input 'yes' if you would like to play again: ");
        ans = Console.ReadLine();

        return ans;
        
        }

        main();

    }
}