using LibraryProgram;

while (true)
{
    
Console.WriteLine("Welcome to the Library.");
Console.WriteLine("Please Select from the following options.");
Console.WriteLine("1. Search for a book with ISBN number.");
Console.WriteLine("2. See which books we have in stock.");
Console.WriteLine("3. Create account");
Console.WriteLine("4. Borrow a book.");
Console.WriteLine("5. Quit");

Dictionary<int, Book> books = new Dictionary<int, Book>();

books.Add(0333791035, new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925,0333791035));
books.Add(0399501487, new Book("Lord of the Flies", "William Goulding", 1954, 0399501487));
books.Add(1529355413, new Book("The Institute", "Stephen King", 2020, 1529355413));
books.Add(1444720723, new Book("The Shining", "Stephen King", 1977, 1444720723));

string userInput = Console.ReadLine();

switch (userInput)
    {
        case "1":
            Console.WriteLine("Please enter the ISBN number below");
            int isbnSearchInput = Convert.ToInt32(Console.ReadLine());

            if (books.ContainsKey(isbnSearchInput))
            {
                Book b = books[isbnSearchInput];
                Console.WriteLine(b.GetBookName() + ". This book was published in " + b.GetYear() + " and the author is " + b.GetAuthor() + ".");
            }

            else
            {
                Console.WriteLine("I'm sorry that isn't a valid input");
            }

            Console.WriteLine("");
        
            continue; // https://stackoverflow.com/questions/1420029/how-to-break-out-of-a-loop-from-inside-a-switch
        
        case "2":
            Console.WriteLine("Here is a list of the books we have available.");
        
            foreach (KeyValuePair<int, Book> book in books)
            {
                Console.WriteLine(book.Value.GetBookName());
            }

            Console.WriteLine("");

            continue;
    
        case "3":
            User a = new User("","");
            Console.WriteLine("Please enter the username you wish to have.");
            string usernameSet = Console.ReadLine().Trim().ToLower();
            a.SetUserName(usernameSet);
            try
            {
                Console.WriteLine("Please enter the password you want.");
                string passwordSet = Console.ReadLine().Trim().ToLower();
                a.SetPassword(passwordSet);
            }
            catch
            {
                Console.WriteLine("Please try again");
            }

            string usern1 = a.GetUserName();
            string pass1 = a.GetPassword();

            Console.WriteLine("Your username is " + usern1 + " and your password is " + pass1);
            Console.WriteLine("");
            continue;
        
        case "4":
            Console.WriteLine("Which book would you like to lend?");
            
            foreach (KeyValuePair<int, Book> book in books)
            {
                Console.WriteLine("Name : " + book.Value.GetBookName() + " ISBN: " + book.Value.GetIsbn());
            }

            Console.WriteLine("");
            Console.WriteLine("Please select which book by inputting the isbn");
            int isbnSearchInput2 = Convert.ToInt32(Console.ReadLine());

            if (books.ContainsKey(isbnSearchInput2))
            {
                Book c = books[isbnSearchInput2];
                Console.WriteLine("You have chosen to borrow " + c.GetBookName());
            }

            else
            {
                Console.WriteLine("That is not a book we have in stock");
            }

            Console.WriteLine("");

            continue;
        
        case "5":
            break;
        

    }
    break;
    
    if (args[0] == "-v")
    {
        Console.WriteLine("Version 4738247538");
        return;
    }
    

}



