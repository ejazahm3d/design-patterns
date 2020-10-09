using System;

namespace Behavioural.Mediator
{
    public class ArticlesDialogBox 
    {
        private readonly ListBox _articlesListBox = new ListBox();
        private readonly TextBox _titleTextBox = new TextBox();
        private readonly Button _saveButton = new Button();
        
        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "Article 1";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");
        }
        delegate void Observer();

        public ArticlesDialogBox()
        {
            _articlesListBox.AddEventHandler(ArticlesSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
        }

        private void ArticlesSelected()
        {
            _titleTextBox.Content = "Hello World";
            _saveButton.IsEnabled = true;

        }

        private void TitleChanged()
        {
            var content = _titleTextBox.Content;
            var isEmpty = string.IsNullOrEmpty(content);
            _saveButton.IsEnabled = !isEmpty;
        }
    }
}