using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Thriller,
        Romance,
        Mystery,
        Comedy,
        ScienceFiction,    
    }
    public class Book
    {
        public string AuthorFullName {  get; set; }
        public string Title { get; set; }
        public int ProductionYear { get; set; }
        public string ISBN { get; set; }
        public Genre BookGenre { get; set;}

        public Book(string authorFullName, string title, int productionYear, string isbn, Genre bookGenre)
        {
            AuthorFullName = authorFullName;
            Title = title;
            ProductionYear = productionYear;
            ISBN = isbn;
            BookGenre = bookGenre;
        }
    }

    public class GenreComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.BookGenre.ToString().CompareTo(y.BookGenre.ToString());
        }
    }

    public class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.AuthorFullName.CompareTo(y.AuthorFullName);
        }
    }

    public class YearComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.ProductionYear.CompareTo(y.ProductionYear);
        }
    }
}
