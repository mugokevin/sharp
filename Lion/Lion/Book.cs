using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion
{
    internal class Book
    {
        public string author;
        public string title;
        public int pages;

        public Book(string aAuthor, string aTitle, int aPages)
        {
            this.author = aAuthor;
            this.title = aTitle;
            this.pages = aPages;
        }
    }
}
