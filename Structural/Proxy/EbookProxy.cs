namespace Structural.Proxy
{
    public class EbookProxy: IEbook
    {
        public string FileName { get; }
        private Ebook _ebook;

        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }


        public void Show()
        {
            _ebook ??= new Ebook(FileName);
            _ebook.Show();
        }
    }
}