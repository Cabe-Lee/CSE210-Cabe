using System;
using System.Text.RegularExpressions;


public class Word
    {
        // The C# convention is to start member variables with an underscore _
        public string _word;
        private int _wordLength;
        public bool _clearWords;
        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Word(string word)
        {
            _word = word;
            _wordLength = _word.Length;
            if (_wordLength > 0)
            {
                if (_word.Substring(0, 1) == "_")
                {
                    _clearWords = true;
                }
            }
            else
            {
                _clearWords = false;
            }
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ClearWord()
        {
            string clear = "";
            clear = Regex.Replace(_word, "[a-zA-Z]", "_");
            _word = clear;
            _clearWords = true;
        }
    }