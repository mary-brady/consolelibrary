using System;
using consolelibrary.Models;

namespace consolelibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library("Da Library!");
            var hp = new Book("Harry Potter and the Chamber of Secrets", "JK Rowling", "1-010101-1", "1998", true);
            var gg = new Book("Gone Girl", "Gillian Flynn", "2-020202-2", "2012", false);
            var katerina = new Book("Katerina", "James Frey", "3-030303-3", "2018", true);
            library.AddBook(hp);
            library.AddBook(gg);
            library.AddBook(katerina);

            var hl = new Game("Half-Life", "Valve", "M", true);
            var rl = new Game("Rocket League", "Psyonix", "E", false);
            var bl = new Game("Borderlands", "2k Games", "M", false);
            library.AddGame(hl);
            library.AddGame(rl);
            library.AddGame(bl);



            Console.WriteLine(library.Name);
            library.ViewBooks();

            var inthelibrary = true;
            while (inthelibrary)
            {
                Console.Clear();
                Console.WriteLine("Welcome to " + library.Name);
                Console.WriteLine("Here's what you can do:");
                Console.WriteLine("1. Check out a book");
                Console.WriteLine("2. Return a book");
                Console.WriteLine("3. Check out a video game");
                Console.WriteLine("4. Return a video game");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do?");

                var UserInput = Console.ReadLine();
                if (Int32.TryParse(UserInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            library.CheckoutBookMenu();
                            break;
                        case 2:
                            library.ReturnBookMenu();
                            break;
                        case 3:
                            library.CheckoutGameMenu();
                            break;
                        case 4:
                            library.ReturnGameMenu();
                            break;
                        case 5:
                            inthelibrary = false;
                            Console.WriteLine("Ok, bye :(");
                            break;
                        default:
                            Console.WriteLine("Invalid - try again");
                            break;
                    }
                }
            }
        }
    }
}
