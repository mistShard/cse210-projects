using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using Microsoft.VisualBasic.FileIO;
    using System.IO;
    class Journal
    {
        private List<Entry> entries = new List<Entry>();


        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public override string ToString()
        {
            return string.Join("\n\n", entries);
        }
        public void LoadEntriesFromFile(string filename)
        {
            entries.Clear();
            TextFieldParser parser = new TextFieldParser(filename);
            parser.HasFieldsEnclosedInQuotes = true;
            parser.SetDelimiters(",");
            string[] fields;
            while (!parser.EndOfData)
            {
                fields = parser.ReadFields();
                AddEntry(new Entry(fields[1], fields[2], DateTime.Parse(fields[0])));
            }
        }
        public void SaveEntriesToFile(string filename)
        {
            List<string> lines = new List<string>();
            
            foreach (Entry entry in entries)
            {
                lines.Add(entry.ToCSVString());
            }
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.Write(string.Join("\n", lines));
            }
        }
    }
}
