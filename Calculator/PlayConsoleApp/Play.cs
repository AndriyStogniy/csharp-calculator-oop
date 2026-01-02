using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayConsoleApp
{
    public class Play: IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        private bool disposed = false;

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;

            Console.WriteLine("Object Play has been created.");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Play info:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine();
        }

        public void Dispose()
        {
            if (disposed)
                return;

            Console.WriteLine($"Play disposed.");
            disposed = true;
        }

        ~Play()
        {
            Console.WriteLine($"Object Play \"{Title}\"  has been destructed by garbage collector");
        }
    }
}
