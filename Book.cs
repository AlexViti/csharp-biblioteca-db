using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class Book : Document
    {
        public long ISBN { get; set; }
        public int Pages { get; set; }

        public Book(long isbn, string title, string sector, int numberOfCopies, int rack, Author author, int pages)
            : base(isbn.ToString(), title, sector, numberOfCopies, rack, author)
        {
            ISBN = isbn;
            Pages = pages;
        }
    }
}
