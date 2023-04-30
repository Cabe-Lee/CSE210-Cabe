using System;
using System.IO;

public class Journal
{
        // The C# convention is to start member variables with an underscore _
        public string _fileName = "";
        public List<string> _entries = new List<string>();

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Journal()
        {
            
        }

        public void AddEntry(string datetime, string prompt, string entry)
        {
            string ety = datetime + " " + prompt + " " + entry;
            _entries.Add(ety);
        }
        
        public void DisplayEntry()
        {
            foreach (string line in _entries)
            {
                Console.WriteLine($"{line}");
            }
        }
        public void SaveJournal()
        {
            GetFileName();
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                foreach (string line in _entries)
                {
                        outputFile.Write("\"" + line + "\"" + ",");
                }
            }
        }
        public void LoadFile()
        {
            GetFileName();
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    foreach (string part in parts) 
                    {
                        string fixpart = part;
                        fixpart = fixpart.Replace("\"", "");
                        if (fixpart != "")
                        {
                            _entries.Add(fixpart);
                        }
                    }
                }
            }
        }
        public void GetFileName()
        {
            Console.WriteLine("What is the filename? (Ex. filename.txt or filename.csv)");
            _fileName = Console.ReadLine();
        }
}