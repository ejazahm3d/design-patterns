using System;

namespace Structural.Proxy
{
    public class Ebook: IEbook
    {
        public string FileName { get; }

        public Ebook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine($"Loading Ebook {FileName}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing the ebook {FileName}");
        }
    }
}