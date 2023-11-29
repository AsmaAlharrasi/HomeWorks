using System.Net;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace HW2_week3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Author and Book Management System!\n");

            Auther auther = new Auther("J.K.Rowling", "British", 1965);
            Console.WriteLine(auther.displayAuthorInfo());

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\n{i + 1}Enter Book Title: ");
                string Title = Console.ReadLine();

                Console.Write("Enter Publication Year: ");
                string PublicationYearstr;
                int.TryParse(Console.ReadLine(), out int PublicationYear);
                

                Console.Write("Enter Genre: ");
                string Genre = Console.ReadLine();

                Books book = new Books
                {
                    Title = Title,
                    PublicationYear = PublicationYear,
                    Genre = Genre
                };
                auther.AddBook(book, i);
            }

               auther.DisplayBooks(); 

        }  
        
    }
}
