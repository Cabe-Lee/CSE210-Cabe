using System;

class Program
{
    static void Main(string[] args)
    {
        Reference [] scriptures = new Reference[3];
        scriptures[0] = new Reference("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scriptures[1] = new Reference("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");
        scriptures[2] = new Reference("Moses", 1, 7, "And now, behold, this one thing I show unto thee, Moses, my son, for thou art in the world, and now I show it unto thee.");

        int index = scriptures[0].ChooseRandomReference(scriptures.Length);
        Scripture scripture = new Scripture(scriptures[index]._content, scriptures[index].GetReference());
        
        scripture.DisplayScripture();
        
        int valid = 1;
        while (valid == 1)
        {
            //Start
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            //Continue
            string input = Console.ReadLine();
            if (input == "")
            {
                input = scripture.HideWords();
                scripture.DisplayScripture();
            }
            if (input == "quit")
            {
                valid = 0;
            }
        }
        Console.WriteLine("Goodbye.");
    }
}