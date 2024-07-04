using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDesktop
{
    [Serializable]
    internal class CredentialsSerializable
    {
        public string HashedPassword { get; set; }
        public byte[] Salt {  get; set; }
        public string Username { get; set; }
    }
}
