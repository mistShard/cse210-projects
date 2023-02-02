using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Prompts
    {
        private static Random _random = new Random();
        private static List<string> _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
        public static string GetRandomPrompt()
        {
            return _prompts[_random.Next(_prompts.Count)];
        }
    }
}
