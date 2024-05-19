namespace WpfApp1;

public class Library
{
    public List<Book> FillLibrary()
    {
        var name = "Идиот";
        var authors = "Ф.М.Достоевский";
        var pages = 640;
        var category = "Роман";
        
        var book1 = new Book(1, name, authors, pages, category);
        
        name = "Преступление и наказание";
        authors = "Ф.М.Достоевский";
        pages = 672;
        category = "Роман";
        
        var book2 = new Book(2, name, authors, pages, category);
        
        name = "Униженные и оскорбленные";
        authors = "Ф.М.Достоевский";
        pages = 448;
        category = "Роман";
        
        var book3 = new Book(3, name, authors, pages, category);
        
        var books = new List<Book>
        {
            book1,
            book2,
            book3
        };

        return books;
    }

    public void ChangeBooksState(List<Book> books, int id, int state)
    {
        ArgumentNullException.ThrowIfNull(books);
        
        foreach (var book in books)
        {
            if (book.GetId() == id)
            {
                book.SetState(state);
            }
        }
    }

    public string GetNameState(int state)
    {
        string nameState = "";

        if (state == 1)
        {
            nameState = "В фонде";
        }

        if (state == 2)
        {
            nameState = "Выдана";
        }

        if (state == 3)
        {
            nameState = "На реставрации";
        }

        return nameState;
    }

    public void AddBook(List<Book> books, int id, string name, string authors, int pages, string category)
    {
        if (CheckId(books, id))
        {
            Console.WriteLine("Книга с таким кодом уже существует");
            return;
        }
        
        var newBook = new Book(id, name, authors, pages, category);
        
        books.Add(newBook);
        
        Console.WriteLine("Книга добавлена");
    }

    private bool CheckId(List<Book> books, int id)
    {
        foreach (var book in books)
        {
            if (book.GetId() == id)
            {
                return true;
            }
        }

        return false;
    }

    public Book GetBook(List<Book> books, int id)
    {
        foreach (var book in books)
        {
            if (book.GetId() == id)
            {
                return new Book(book.GetId(), book.GetName(), book.GetAuthors(), book.GetPages(), book.GetCategory(), book.GetState());
            }
        }

        return new Book(0, "", "", 0, "");
    }

    public void ChangeBookId(List<Book> books, int id, int newId)
    {
        foreach (var book in books)
        {
            if (book.GetId() == id) 
            {
                book.SetId(newId);
            }
        }
    }
}