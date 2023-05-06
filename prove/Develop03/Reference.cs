using System;


public class Reference
    {
        // The C# convention is to start member variables with an underscore _
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
        public string _content;
        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Reference(string book, int chapter, int verse, string content)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = verse;
            _endVerse = verse;
            _content = content;
        }
        public Reference(string book, int chapter, int startverse, int endverse, string content)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startverse;
            _endVerse = endverse;
            _content = content;
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public string GetReference()
        {
            string reference = "";
            if (_startVerse == _endVerse)
            {
                reference = _book + " " + _chapter + ":" + _startVerse;
            }
            else
            {
                reference = _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse;
            }
            return reference;
            
        }
        public int ChooseRandomReference(int length)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, length);
            return number;
        }
    }