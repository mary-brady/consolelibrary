using System;
using System.Collections.Generic;

namespace consolelibrary.Models
{
    public class Library
    {
        public string Name { get; private set; }
        public Library(string name)
        {
            Name = name;
        }
        List<Book> Books = new List<Book>();
        List<Game> Games = new List<Game>();

        public void ViewBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Book book = Books[i];
                string availableText = (book.Available ? "Available" : "Not Available");
                Console.WriteLine($"{i + 1} - {book.Title} -- {book.Author} -- {availableText}");
            }
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        private Book GetBookFromUserChoice()
        {
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                n = n - 1;
                if (n < 0 || n >= Books.Count)
                {
                    return null;
                }
                return Books[n];
            }
            return null;
        }

        private Game GetGameFromUserChoice()
        {
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                n = n - 1;
                if (n < 0 || n >= Games.Count)
                {
                    return null;
                }
                return Games[n];
            }
            return null;
        }

        public void AddGame(Game game)
        {
            Games.Add(game);
        }

        public void CheckoutBookMenu()
        {
            var checkingoutabook = true;
            while (checkingoutabook)
            {
                Console.Clear();
                ViewBooks();
                Console.WriteLine($"{Books.Count + 1} - GO BACK");
                Book book = GetBookFromUserChoice();
                if (book == null)
                {
                    checkingoutabook = false;
                }
                else
                {
                    book.Available = false;
                }
            }
        }

        public void CheckoutGameMenu()
        {
            var checkingoutagame = true;
            while (checkingoutagame)
            {
                Console.Clear();
                ViewGames();
                Console.WriteLine($"{Games.Count + 1} - Go Back");
                Game game = GetGameFromUserChoice();
                if (game == null)
                {
                    checkingoutagame = false;
                }
                else
                {
                    game.Available = false;
                }
            }
        }

        public void ReturnBookMenu()
        {
            var returningabook = true;
            while (returningabook)
            {
                Console.Clear();
                ViewBooks();
                Console.WriteLine($"{Books.Count + 1} - Go Back");
                Book book = GetBookFromUserChoice();
                if (book == null)
                {
                    returningabook = false;
                }
                else
                {
                    book.Available = true;
                }
            }
        }

        public void ReturnGameMenu()
        {
            var returningagame = true;
            while (returningagame)
            {
                Console.Clear();
                ViewGames();
                Console.WriteLine($"{Games.Count + 1} - Go Back");
                Game game = GetGameFromUserChoice();
                if (game == null)
                {
                    returningagame = false;
                }
                else
                {
                    game.Available = true;
                }
            }
        }

        public void ViewGames()
        {
            for (int i = 0; i < Games.Count; i++)
            {
                Game game = Games[i];
                string availableText = (game.Available ? "Available" : "Not Available");
                Console.WriteLine($"{i + 1} - {game.Title} -- {game.Studio} -- {game.Rating} -- {availableText}");
            }
        }

    }
}