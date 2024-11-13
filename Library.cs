class Library
{
    // Data fields
    private List<Book> books;
    private List<Person> people;

    // Configuration
    public Library()
    {
        books = new List<Book>();
        people = new List<Person>();
    }

    // Methods, things we can do with the object
    public void AddNewBook(Book newBook)
    {
        books.Add(newBook);
    }

   public void AddNewPerson(Person newPerson)
    {
        people.Add(newPerson);
    }

    public List<Person> ListAllPeople() 
    {
        return people;
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