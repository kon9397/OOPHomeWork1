using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите автора");
            string author = Console.ReadLine();
            Console.WriteLine("Введите название");
            string title = Console.ReadLine();
            Console.WriteLine("Введите текст");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);

            book.author.Show();
            book.title.Show();
            book.content.Show();

            Console.ReadKey();
        }
    }
}
