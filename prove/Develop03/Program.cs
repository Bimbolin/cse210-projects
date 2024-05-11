using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("John 3:16", "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");
        Console.Clear();
        Console.WriteLine(scripture);

        while (true)
        {
            Console.WriteLine("\nPress enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords();
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.IsFullyHidden)
            {
                Console.WriteLine("\nAll words are hidden. Exiting program.");
                break;
            }
        }
    }
}

