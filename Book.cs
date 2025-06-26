using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Year;
        public int Pages;

        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public void Show()
        {
            Console.WriteLine($"{Author} {Title} {Year}г {Pages}с");
        }
    }
}
