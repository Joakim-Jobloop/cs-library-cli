
Console.WriteLine("Welcome to the library's book system");
Console.WriteLine("------------");
bool runProgram = true;
while (runProgram)
{

    // read user input:
    Console.WriteLine("Do you want to lend or return");
    string? userInput = Console.ReadLine();

    Console.WriteLine("------------");
    if (userInput == "lend")
    {
        Console.WriteLine("Lending a book");
        Console.WriteLine("Which book would you like to lend?");
        string? userLendBook = Console.ReadLine();
        if (userLendBook != null)
        {
            Console.WriteLine("Lending book: " + userLendBook);
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




Console.WriteLine("------------");
// Echo back what the user input:
// Console.WriteLine("You chose: " + userInput);