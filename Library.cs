class Library
{
    // Data fields
    private List<Book> books;

    // Configuration
    public Library()
    {
        books = new List<Book>();
    }

    // Methods, things we can do with the object
    public void AddNewBook(Book newBook)
    {
        books.Add(newBook);
    }

    public List<Book> ListAvaliableBooks()
    {
        return books;
    }

    public Book? LendBook(string title)
    {
        Book? book = books.Find((book) =>
        {
            if (book.Title == title)
            {
                return true;
            }
            else
            {
                return false;
            }
        });
        return book;
    }

}