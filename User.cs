using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class User : Person
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public List<Rent> Rents { get; }

        public User(string surname, string name, string email, string password, long phone) : base(surname, name)
        {
            Email = email;
            Password = password;
            Phone = phone;
            Rents = new List<Rent>();
        }
    }
}
