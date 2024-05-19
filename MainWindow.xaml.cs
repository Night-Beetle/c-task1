using System.Windows;

namespace WpfApp1;

public partial class MainWindow : Window
{
    private readonly Library _library = new Library();
    private List<Book> _books;
    
    public MainWindow()
    {
        InitializeComponent();
        _books = _library.FillLibrary();
        
        ButtonAdd.Click += new RoutedEventHandler(this.ButtonAddClick);
        ButtonGet.Click += new RoutedEventHandler(this.ButtonGetClick);
        ButtonSetId.Click += new RoutedEventHandler(this.ButtonSetIdClick);
        ButtonTake.Click += new RoutedEventHandler(this.ButtonTakeClick);
        ButtonRestoration.Click += new RoutedEventHandler(this.ButtonRestorationClick);
    }

    private void ButtonAddClick(object sender, EventArgs e)
    {
        _library.AddBook(_books, int.Parse(TextBoxId.Text), TextBoxName.Text, TextBoxAuthors.Text, int.Parse(TextBoxPages.Text), TextBoxCategory.Text);
    }

    private void ButtonGetClick(object sender, EventArgs e)
    {
        var book = _library.GetBook(_books, int.Parse(TextBoxId.Text));

        TextBoxId.Text = book.GetId().ToString();
        TextBoxName.Text = book.GetName();
        TextBoxAuthors.Text = book.GetAuthors();
        TextBoxPages.Text = book.GetPages().ToString();
        TextBoxCategory.Text = book.GetCategory();
        TextBoxState.Text = _library.GetNameState(book.GetState());
    }

    private void ButtonSetIdClick(object sender, EventArgs e)
    {
        int newId = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Введите новый код: "));
        _library.ChangeBookId(_books, int.Parse(TextBoxId.Text), newId);
    }
    
    private void ButtonTakeClick(object sender, EventArgs e)
    {
        _library.ChangeBooksState(_books, int.Parse(TextBoxId.Text), 2);
    }
    
    private void ButtonRestorationClick(object sender, EventArgs e)
    {
        _library.ChangeBooksState(_books, int.Parse(TextBoxId.Text), 3);
    }
}