using System;

namespace Structural.Proxy
{
    public class LoggingEbookProxy: IEbook
    {
        public string FileName { get; }
        private Ebook _ebook;

        public LoggingEbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            _ebook ??= new Ebook(FileName);
            Console.WriteLine("logging");
            _ebook.Show();
        }
    }
}