namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Price = 6;
            book1.Count = 20;
            book1.No = 1;
            book1.Name = "The Picture of Dorian Gray";
            book1.Genre = "Philosophical fiction";
            Book book2 = new Book();
            book2.Price = 5;
            book2.Count = 22;
            book2.No = 2;
            book2.Name = "Fathers and Sons";
            book2.Genre = "Novel";
            Book book3 = new Book();
            book3.Price = 7;
            book3.Count = 24;
            book3.No = 3;
            book3.Name = "The Myth of Sisyphus";
            book3.Genre = "Philosophical";
            Console.WriteLine("Information of books:");
            book1.ShowInfo();
            book2.ShowInfo();
            book3.ShowInfo();
            Library library = new Library();
            library.Addbook(book1);
            library.Addbook(book2);
            library.Addbook(book3);
            Console.WriteLine("---------------------------------------\n\n");
            Console.WriteLine("List of books in this genre:");
            library.GetFilteredBooks("Novel");
            Console.WriteLine("\n\n");
            Console.WriteLine("List of books in this price range:");
            library.GetFilteredBooks(4, 10);
            Console.WriteLine("\n\n");
            Console.WriteLine("All books:");
            library.ShowAllBooks();
        }
    }
}
