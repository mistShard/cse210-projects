using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Entry
    {
        private readonly string _prompt;
        private readonly string _response;
        private readonly DateTime _date;

        public Entry(string _prompt, string _response, DateTime _date)
        {
            this._prompt = _prompt;
            this._response = _response;
            this._date = _date;
        }
        public string GetShortDateString()
        {
            return _date.ToShortDateString();
        }
        public override string ToString()
        {
            return $"Date: {GetShortDateString()} - Prompt: {_prompt}\n{_response}";
        }
        public string ToCSVString()
        {
            return $"{_date},\"{ReplaceSingleParentheses(_prompt)}\",\"{ReplaceSingleParentheses(_response)}\"";
        }

        private string ReplaceSingleParentheses(string input)
        {
            return input.Replace("\"", "\"\"");
        }

    }
}
