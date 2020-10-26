using System.Collections.Generic;

namespace Structural.Proxy
{
    public class Library
    {
        private readonly Dictionary<string, IEbook> _ebooks = new Dictionary<string, IEbook>();
        public void Add(IEbook ebook)
        {
            _ebooks.Add(ebook.FileName, ebook);
            
        }

        public void OpenEbook(string fileName)
        {
            _ebooks[fileName].Show();
        }
    }
}