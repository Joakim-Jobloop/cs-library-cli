class Book
{
    public string Title;
    public string Author;
    public DateTime FirstPublished;

    public string BookId;

    public Book(string title, string author, DateTime firstPublished, string bookId)
    {
        Title = title;
        Author = author;
        FirstPublished = firstPublished;
        BookId = bookId;
    }
}


