using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Book
    {
        public Title title;
        public Author author;
        public Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
    }
}
