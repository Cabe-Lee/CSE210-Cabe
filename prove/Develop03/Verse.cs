using System;


public class Entry
    {
        // The C# convention is to start member variables with an underscore _
        public string _datetime = "";
        public string _promptUser = "";
        public string _resoponseUser = "";
        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Entry()
        {
            
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void GetRandomPrompt()
        {
            PromptGenerator prompt = new PromptGenerator();
            prompt.GeneratePrompt();
            _promptUser = prompt._generatePrompt;

            Console.WriteLine($"{_promptUser}");
            _resoponseUser = Console.ReadLine();
        }
        public void GetDate()
        {
            DateTime theCurrentTime = DateTime.Now;
            _datetime = theCurrentTime.ToShortDateString();
        }
    }