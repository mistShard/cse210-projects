using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Entry
    {
        private readonly string prompt;
        private readonly string response;
        private readonly DateTime date;

        public Entry(string prompt, string response, DateTime date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
        public string GetShortDateString()
        {
            return date.ToShortDateString();
        }
        public override string ToString()
        {
            return $"Date: {GetShortDateString()} - Prompt: {prompt}\n{response}";
        }
        public string ToCSVString()
        {
            return $"{date},\"{ReplaceSingleParentheses(prompt)}\",\"{ReplaceSingleParentheses(response)}\"";
        }

        private string ReplaceSingleParentheses(string input)
        {
            return input.Replace("\"", "\"\"");
        }

    }
}
