using System;

class Program
{
    static void Main(string[] args)
    {
        int valid = 1;
        while (valid == 1)
        {
            Console.WriteLine("Flavor Text");
            Console.WriteLine("Fork Road Flavor Text");
            Console.WriteLine("Which option do you choose?");
            Console.WriteLine("     1. Left");
            Console.WriteLine("     2. Middle");
            Console.WriteLine("     3. Right");
            Console.WriteLine("     4. Quit");
            

            //      //
            int path = Console.Read();
            if (path == 1)
            {
                
            }
            if (path == 2)
            {
                
            }
            if (path == 3)
            {
                
            }
            if (path == 4)
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing the game. Goodbye.");
                valid = 0;
            }
            else
            {
                Console.WriteLine("Please type a number. Ex. 1 - 4");
            }
        }
    }
}