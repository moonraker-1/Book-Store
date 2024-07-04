using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Navigation;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStoreDesktop
{
    internal static class Serializer
    {

        /// <summary>
        /// FOR BOOKS
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        public static bool Serialize(List<Book> books)
        {
            if (books == null || books.Count == 0) return false;
            string filePath = "lib.json";
            try
            {
                string libJson = JsonSerializer.Serialize(books);
                File.WriteAllText(filePath, libJson);
            }
            catch (Exception ex) 
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// FOR CREDENTIALS
        /// </summary>
        /// <param name="credentials"></param>
        /// <returns></returns>
        public static bool Serialize(List<CredentialsSerializable> credentials) 
        {
            if (credentials == null || credentials.Count == 0) return false;
            string filePath = "cred.json";
            try
            {
                string libJson = JsonSerializer.Serialize(credentials);
                File.WriteAllText(filePath, libJson);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// FOR BOOKS
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<Book> Deserialize(string filePath)
        {
            List<Book> books = new List<Book>();
            try
            {
                string libJson = File.ReadAllText(filePath);
                books = JsonSerializer.Deserialize<List<Book>>(libJson);
            }
            catch (Exception ex)
            {
                return null;
            }
            return books;
        }


        /// <summary>
        /// FOR CREDENTIALS
        /// </summary>
        /// <returns></returns>
        public static List<CredentialsSerializable> Deserialize()
        {
            List<CredentialsSerializable> credentials = new List<CredentialsSerializable>();
            try
            {
                string libJson = File.ReadAllText("cred.json");
                credentials = JsonSerializer.Deserialize<List<CredentialsSerializable>>(libJson);
            }
            catch (Exception ex)
            {
                return null;
            }
            return credentials;
        }
    }
}
