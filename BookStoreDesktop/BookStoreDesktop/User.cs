using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDesktop
{
    /// <summary>
    /// A class for handling user information
    /// </summary>
    [Serializable]
    internal class User
    {
        private int id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public User() { }
        public User(int id)
        {
            this.id = id;
        }
        public void generateID(int lastId)
        {
            this.id = lastId + 1;
        }
    }
}
