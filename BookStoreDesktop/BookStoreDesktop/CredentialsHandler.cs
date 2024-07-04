using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable SYSLIB0023
#pragma warning disable SYSLIB0041


namespace BookStoreDesktop
{
    internal class CredentialsHandler
    {
        public static string EnteredUsername { get; set; }
        public static string EnteredPassword { get; set; }

        private static string storedPassword;

        private static List<CredentialsSerializable> creds;
        public static bool CheckCredentials()
        {

            creds = Serializer.Deserialize();
            if (creds == null) creds = new List<CredentialsSerializable>();

            int position = 0;
            foreach (CredentialsSerializable cred in creds)
            {
                if (cred.Username == EnteredUsername)
                {
                    if (decode(cred.HashedPassword, cred.Salt, 10000, 20))
                    {
                        return true;
                    }
                }
                position++;
            }
            return false;
        }

        public static void RegisterCredentials()
        {
            creds = Serializer.Deserialize();
            if (creds == null) creds = new List<CredentialsSerializable>();

            byte[] preparedSalt = generateSalt(96);
            storedPassword = encode(preparedSalt, 10000, 20);
            creds.Add(new CredentialsSerializable 
            { 
                Username = EnteredUsername, 
                HashedPassword = storedPassword, 
                Salt = preparedSalt 
            });
            Serializer.Serialize(creds); 
        }

        private static bool decode(string storedHash, byte[] salt, int iterations, int hashByteSize)
        {
            string enteredHash = encode(salt, iterations, hashByteSize);
            return storedHash == enteredHash;
        }

        private static string encode(byte[] salt, int iterations, int hashByteSize)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(EnteredPassword, salt, iterations))
            {
                byte[] hash = pbkdf2.GetBytes(hashByteSize);
                return Convert.ToBase64String(hash);
            }
        }


        private static byte[] generateSalt(int size)
        {
            var salt = new byte[size];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        //public CredentialsHandler()
        //{

        //}

        //internal 
    }
}
