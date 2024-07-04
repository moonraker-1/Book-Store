using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDesktop
{
    [Serializable]
    internal class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public double Price {  get; set; }

    }
}
