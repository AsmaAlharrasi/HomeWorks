using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_week3
{
    internal class Books
    {
        public string Title;
        public string Genre;
        public int PublicationYear;

        public Books()
        {

        }
        public Books(string Title, string Genre, int PublicationYear)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.PublicationYear = PublicationYear;
        }

        public string DisplayBookInfo() => $"Title: {this.Title} \nGenre: {this.Genre}" +
            $" \nPublication Year: {this.PublicationYear}";
        
    }
}
