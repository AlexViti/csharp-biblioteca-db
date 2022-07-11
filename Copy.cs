using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class Copy : Book
    {
        public new int Id { get; private set; }
        public int BookId { get; private set; }
        public string Condition { get; set; }
        public int LibraryCode { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public long ISBN { get; set; }
        public int Pages { get; set; }

        public Copy(Book book, int id, string condition, int libraryCode, string publisher, string language, long isbn, int pages)
            : base(book.Id, book.Title, book.Author, book.Year, book.Plot, book.AgeRange)
        {
            Id = id;
            BookId = book.Id;
            Condition = condition;
            LibraryCode = libraryCode;
            Publisher = publisher;
            Language = language;
            ISBN = isbn;
            Pages = pages;
        }
    }
}
