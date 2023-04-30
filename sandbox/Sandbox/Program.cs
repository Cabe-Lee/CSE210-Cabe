using System;

class Program
{

    static void Main(string[] args)
    {
        // 
        //Console.WriteLine("Hello world! Say yes or no.");
        //string word = Console.ReadLine();

        Person person = new Person();
        person._givenName = "Joseph";
        person._familyName = "Smith";
        person.ShowWesternName();
        person.ShowEasternName();

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
        
        // AND = &&, OR = ||, NOT = !.
        Console.WriteLine("Name a biblical name.");
        string name = Console.ReadLine();
        if (name == "Peter" || name == "James" || name == "John")
        {
            Console.WriteLine("This is a biblical name.");
        }

        Console.WriteLine("Name a prophet's first name.");
        string firstName = Console.ReadLine();
        Console.WriteLine("Name a prophet's last name.");
        string lastName = Console.ReadLine();
        if (firstName == "Brigham" && lastName == "Young")
        {
            Console.WriteLine("Welcome Brother Brigham!");
        }
    }
}