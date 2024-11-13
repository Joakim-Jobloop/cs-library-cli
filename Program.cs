
// Setup the Library:
Library library = new Library();

// Add books:
Book cookWithGandalf = new Book("You Shall Not Fast: A Cookbook", "Gandalf the Grey", new DateTime(3019, 3, 25), "1");
Book catGuide = new Book("How to Knock Over Everything", "Whiskers the Cat", new DateTime(2023, 1, 1), "2");
Book elfPsychology = new Book("Am I Overthinking This?", "An Elf on the Shelf", new DateTime(2020, 12, 1), "3");
Book programmerLife = new Book("Infinite Loops and Caffeine", "Anonymous Programmer", new DateTime(2024, 5, 7), "4");
Book gymRegret = new Book("Never Leg Day", "Skip Legman", new DateTime(2022, 4, 12), "4");
Book procrastinator = new Book("I'll Finish This Book Tomorrow", "Pro Crastinator", new DateTime(2025, 6, 30), "5");
Book catSecrets = new Book("The Art of the Perfect Nap", "Garfield", new DateTime(1978, 6, 19), "6");
Book sarcasmGuide = new Book("Oh, Really?", "Dr. Sarcasm", new DateTime(2018, 9, 15), "7");
Book alienMemoirs = new Book("Earthlings: A Field Guide", "Zorg of Planet X", new DateTime(2050, 11, 11), "8");
Book timeTravel = new Book("Oops, Wrong Century", "Time Traveler X", new DateTime(1805, 3, 14), "9");
library.AddNewBook(cookWithGandalf);
library.AddNewBook(catGuide);
library.AddNewBook(catSecrets);
library.AddNewBook(elfPsychology);
library.AddNewBook(programmerLife);
library.AddNewBook(gymRegret);
library.AddNewBook(procrastinator);
library.AddNewBook(sarcasmGuide);
library.AddNewBook(alienMemoirs);
library.AddNewBook(timeTravel);

Person joakim = new Person("Joakim Villo", 36, "gojhfdi");
library.AddNewPerson(joakim);

Person bob = new Person("Bob Marley", 76, "gogfdusagfduyjhfdi");
library.AddNewPerson(bob);
bob.PersonBorrowBook(cookWithGandalf);

joakim.PersonBorrowBook(timeTravel);
joakim.PersonBorrowBook(alienMemoirs);


Console.WriteLine("Welcome to the library's book system");
Console.WriteLine("------------");
bool runProgram = true;
while (runProgram)
{

    // read user input:
    Console.WriteLine("Do you want to lend or return");
    string? userInput = Console.ReadLine();

    Console.WriteLine("------------");
    // List out avaliable books:
    if (userInput == "list")
    {
        Console.WriteLine("Here are the avaliable books:");
        List<Book> avaliableBooks = library.ListAvaliableBooks();

        foreach (var book in avaliableBooks)
        {
            Console.WriteLine($"Title: {book.Title}. Author: {book.Author}. Published: {book.FirstPublished}");
        }

    }
    else if (userInput == "info") {
             Console.WriteLine("Here are the customers:");
        List<Person> allPersons = library.ListAllPeople();
        List<Book> borrowedBooks = joakim.ListBorrowedBooks();

        foreach (var person in allPersons)
        {
            Console.WriteLine($"{person.Fullname} is {person.Age} years old. Id: {person.CustomerId}.");
            foreach (var book in borrowedBooks) {
                Console.WriteLine($"{book.Title}");
            }
        }
    }
    else if (userInput == "lend")
    {
        Console.WriteLine("Lending a book");
        Console.WriteLine("Which book would you like to lend?");
        string? wantedBookTitle = Console.ReadLine();
        Book? book = library.LendBook(wantedBookTitle);
        if (book == null)
        {
            Console.WriteLine("No book found: " + wantedBookTitle);
        }
        else
        {
            Console.WriteLine("Lending book: " + book.Title);
        }
    }
    // To return a book
    else if (userInput == "return")
    {
        Console.WriteLine("Returning a book");
        Console.WriteLine("Which book would you like to return?");
        string? userBookReturn = Console.ReadLine();
        if (userBookReturn != null)
        {
            Console.WriteLine("Returning book: " + userBookReturn);
        }
    }
    // To end the program
    else if (userInput == "exit")
    {
        runProgram = false;
    }
    // If user inputs something completely different:
    else
    {

    }
    Console.WriteLine("------------");
}




Console.WriteLine("-----Ending-----");
// Echo back what the user input:
// Console.WriteLine("You chose: " + userInput);