using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace HW2_week3
{
    internal class Auther
    {
        public string AutherName;
        public string Nationality;
        public int BirthYear;
        public Books[] book = new Books[3];

        public Auther(string AutherName , string Nationality , int BirthYear)
        {
            this.AutherName = AutherName;
            this.Nationality = Nationality;
            this.BirthYear = BirthYear;

        }
        public string displayAuthorInfo() => $"Name: {this.AutherName} \nBirth Year: " +
            $"{this.BirthYear} \nNationality: {Nationality}";

        
        public void DisplayBooks ()
        {
            Console.WriteLine($"Books Authored by {AutherName}:");
            for (int i = 0; i < book.Length; i++)
            {
               // if (book[i] != null)
                
                    Console.Write($"{i + 1}. ");
                    book[i].DisplayBookInfo();
                
            }
        }


        public void AddBook(Books books, int index)
        {
            if (index >= 0 && index < book.Length)
            book[index] = books;
            
        }




    }

        

    


}
