namespace WpfApp1;

public class Book(int id, string name, string authors, int pages, string category, int state = 1)
{
    private readonly string _name = name;
    private readonly string _authors = authors;
    private readonly int _pages = pages;
    private readonly string _category = category;
    private int _state = state;
    private int _id = id;

    public string GetName()
    {
        return _name;
    }

    public int GetPages()
    {
        return _pages;
    }

    public string GetCategory()
    {
        return _category;
    }

    public string GetAuthors()
    {
        return _authors;
    }

    public int GetId()
    {
        return _id;
    }

    public int GetState()
    {
        return _state;
    }

    public void SetId(int id)
    {
        _id = id;
    }
    
    public void SetState(int state)
    {
        _state = state;
    }
}