string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

// Question 1: Given int pages = 464; and bool isAvailable = true;
// print "You can borrow this book" only if pages > 300 and isAvailable is true. Use &&.
{
    int pages = 464;
    bool isAvailable = true;

    if (pages > 300 && isAvailable)
    {
        Console.WriteLine("You can borrow this book");
    }
}

// Question 2: Given string title = "Refactoring";
// switch: "Clean Code" -> "Great choice!", "Refactoring" -> "Nice pick!", else "Never heard of it".
{
    string title = "Refactoring";

    switch (title)
    {
        case "Clean Code":
            Console.WriteLine("Great choice!");
            break;
        case "Refactoring":
            Console.WriteLine("Nice pick!");
            break;
        default:
            Console.WriteLine("Never heard of it");
            break;
    }
}

// Question 3: Given int pages = 464;
// use the ternary operator to store "Long Book" or "Short Book" in sizeLabel (long if pages > 300).
{
    int pages = 464;
    string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
    Console.WriteLine(sizeLabel);
}

// Question 4: Using the books array, use a for loop to print each book
// with its position number, like 1. Clean Code.
{
    for (int i = 0; i < books.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {books[i]}");
    }
}

// Question 5: Using the same books array, use a while loop to print every book title.
{
    int i = 0;
    while (i < books.Length)
    {
        Console.WriteLine(books[i]);
        i++;
    }
}

// Question 6: Write a do-while loop that prints "Checking book..." exactly 3 times.
{
    int count = 0;
    do
    {
        Console.WriteLine("Checking book...");
        count++;
    } while (count < 3);
}

// Question 7: Using the same books array, use a foreach loop to print every book title.
{
    foreach (string book in books)
    {
        Console.WriteLine(book);
    }
}

// Question 8: Using the same books array, loop through it and print each title,
// but stop completely (break) once you reach "Refactoring".
{
    foreach (string book in books)
    {
        if (book == "Refactoring")
            break;

        Console.WriteLine(book);
    }
}

// Question 9: Using the same books array, print every title except "The Pragmatic Programmer"
// (skip it with continue, don't stop the loop).
{
    foreach (string book in books)
    {
        if (book == "The Pragmatic Programmer")
            continue;

        Console.WriteLine(book);
    }
}

// Question 10: Write a method PrintFirstBook() that prints the first book in the books array.
// If the array is empty, use return to exit the method early instead of printing anything.
void PrintFirstBook()
{
    if (books.Length == 0)
        return;

    Console.WriteLine(books[0]);
}

PrintFirstBook();