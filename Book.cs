using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class Book
    {
        public int Id { get; protected set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Plot { get; set; }
        public int AgeRange { get; set; }

        public Book(int id, string title, string author, string year, string plot, int ageRange)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Plot = plot;
            AgeRange = ageRange;
        }
    }
}
