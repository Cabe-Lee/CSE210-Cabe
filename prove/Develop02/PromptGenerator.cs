using System;


public class PromptGenerator
    {
        // The C# convention is to start member variables with an underscore _
        public string _generatePrompt = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.

        public PromptGenerator()
        {
            
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void GeneratePrompt()
        {

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 5);
                
            if (number == 1)
            {
                _generatePrompt = "Who was the most interesting person I interacted with today?";
            }
            else if (number == 2)
            {
                _generatePrompt = "What was the best part of my day?";
            }
            else if (number == 3)
            {
                _generatePrompt = "How did I see the hand of the Lord in my life today?";
            }
            else if (number == 4)
            {
                _generatePrompt = "What was the strongest emotion I felt today?";
            }
            else if (number == 5)
            {
                _generatePrompt = "If I had one thing I could do over today, what would it be?";
            }
            else
            {
                _generatePrompt = "OOPS ERROR.";
            }
        }
    }