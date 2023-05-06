using System;


public class Scripture
    {
        // The C# convention is to start member variables with an underscore _
        private string _contents;
        private string _reference;
        private int _contentLength;
        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Scripture(string contents, string reference)
        {
            _contents = contents;
            _reference = reference;
            string[] content = _contents.Split(" ");
            int i = 0;
            foreach (string wd in content) {i++;}
            _contentLength = i;
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void DisplayScripture()
        {
            Console.Clear();
            Console.WriteLine($"{_reference} {_contents}");
        }
        public string HideWords()
        {
            string input = "";
            Word[] word = new Word[_contentLength];
            int i = 0;
            string[] content = _contents.Split(" ");
            foreach (string wd in content)
            {
                word[i] = new Word(wd);
                i++;
            }
            int valid = 3;
            int exit = 0;
            while (valid > 0)
            {
                i = ChooseRandomScripture(_contentLength);
                if (word[i]._clearWords == false)
                {
                    word[i].ClearWord();
                    valid = valid - 1;
                }
                exit++;
                if (exit == 2 * _contentLength)
                {
                    for (int a = 0; a < _contentLength; a++)
                    {
                        word[a].ClearWord();
                    }
                    valid = 0;
                    input = "quit";
                }
            }
            string newcontent = "";
            for (i = 0; i < _contentLength; i++)
            {
                if (i == _contentLength - 1)
                {
                    newcontent += word[i]._word;
                }
                else
                {
                    newcontent += word[i]._word + " ";
                }
                
            }
            _contents = newcontent;
            return input;
        }
        private int ChooseRandomScripture(int length)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, length);
            return number;
        }
    }