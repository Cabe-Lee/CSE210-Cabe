using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        //Person person = new Person();
        //person._givenName = "Joseph";
        //person._familyName = "Smith";
        //person.ShowWesternName();
        //person.ShowEasternName();


        // 1. Input string yes or no with if, else if, and else conditions 
        // and print the variable.
        //Console.WriteLine("Hello world! Say yes or no.");
        //string word = Console.ReadLine();
        //Console.WriteLine($"There will not be a newline after this. {word}");

        //if (word == "yes")
        //{
            //Console.WriteLine("You like blue, I like blue.");
        //}
        //else if (word == "no")
        //{
            //Console.WriteLine("I still like to be a friend. If you don't want to be friends, fine, I'll leave you to what you like to do without me.");
        //}
        //else
        //{
            //Console.WriteLine("Please say yes or no.");
        //}
        

        // 2. AND = &&, OR = ||, NOT = !.
        //Console.WriteLine("Name a biblical name.");
        //string name = Console.ReadLine();
        //if (name == "Peter" || name == "James" || name == "John")
        //{
            //Console.WriteLine("This is a biblical name.");
        //}

        //Console.WriteLine("Name a prophet's first name.");
        //string firstName = Console.ReadLine();
        //Console.WriteLine("Name a prophet's last name.");
        //string lastName = Console.ReadLine();
        //if (firstName == "Brigham" && lastName == "Young")
        //{
            //Console.WriteLine("Welcome Brother Brigham!");
        //}


        // 3. Convert string to number, and number to string through 
        // local variables.
        //int y = 10;
        //int z = 30;
        //Console.WriteLine("What is x?");
        //string number = Console.ReadLine();
        //int x = int.Parse(number);

        //if (x > y)
        //{
            //Console.WriteLine("x is greater than y.");
        //}
        //if (x < y)
        //{
            //Console.WriteLine("x is lesser than y.");
        //}
        //if (x > z)
        //{
            //Console.WriteLine("x is greater than z.");
        //}
        //if (x < z)
        //{
            //Console.WriteLine("z is lesser than z.");
        //}

        //string numberString = x.ToString();


        // While loop
        //string yes = "yes";
        //while (yes == "yes")
        //{
            //Console.WriteLine("Do you want to continue?");
            //Console.WriteLine("type: | yes | | no |");
            //yes = Console.ReadLine();
            //if (yes == "no")
            //{
                //Console.WriteLine("End program.");
            //}
            //else
            //{
                //Console.WriteLine("You are in a loop.");
            //}
        //}


        // For and Foreach
        //for (int i = 0; i < 10; i++)
        //{
            //Console.WriteLine(i);
        //}
        //for (int i = 2; i <= 20; i = i + 2)
        //{
        //    Console.WriteLine(i);
        //}
        //for (int i = 3; i <= 30; i = i * 10)
        //{
        //    Console.WriteLine(i);
        //}

        //List<string> colors = new List<string>();
        //colors.Add("Blue");
        //colors.Add("Red");
        //colors.Add("Yellow");
        //foreach (string color in colors)
        //{
        //    Console.WriteLine(color);
        //}
        
        
        // Random function
        //Random rdm = new Random();
        //int bob = rdm.Next(1, 3);

        //if (bob == 1)
        //{
            //Console.WriteLine("Is this your card? 1. A");
        //}
        //if (bob == 2)
        //{
            //Console.WriteLine("Is this your card? 2. B");
        //}
        //if (bob == 3)
        //{
            //Console.WriteLine("Is this your card? 3. C");
        //}
        Account savings = new Account();
        savings._balance = 50;
        savings.Deposit(100);
        public class Account
        {
            public int _balance = 0;

            public void Deposit(int amount)
            {
                _balance = _balance + amount;
            }
            
        }
        
    }
}