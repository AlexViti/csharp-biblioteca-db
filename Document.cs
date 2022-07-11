using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal abstract class Document
    {
        public string Code { get; protected set; }
        public string Title { get; set; }
        public string Sector { get; set; }
        public int NumberOfCopies { get; set; }
        public int RentedCopies { get; private set; }
        public int Rack { get; set; }
        public Author Author { get; set; }

        protected Document(string code, string title, string sector, int numberOfCopies, int rack, Author author)
        {
            Code = code;
            Title = title;
            Sector = sector;
            NumberOfCopies = numberOfCopies;
            RentedCopies = 0;
            Rack = rack;
            Author = author;
        }

        public void AddRentedCopies()
        {
            RentedCopies++;
        }

        public void RemoveRentedCopies()
        {
            RentedCopies--;
        }
    }
}
