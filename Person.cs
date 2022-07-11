using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal abstract class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }


        protected Person(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }
    }
}
