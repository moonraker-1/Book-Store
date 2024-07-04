using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace BookStoreDesktop
{
    internal static class Serializer
    {
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
    }
}
