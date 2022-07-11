using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}
