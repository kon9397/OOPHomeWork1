using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Content
    {
        public string content;
        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content, Console.ForegroundColor);
        }
    }
}
