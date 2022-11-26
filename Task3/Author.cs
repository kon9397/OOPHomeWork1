using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Author
    {
        string authorName;
        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(authorName, Console.ForegroundColor);
        }
    }
}
