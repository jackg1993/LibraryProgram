namespace LibraryProgram;

public class Book
{
    private string bookName; // Name of book
    private string author; // Author of book
    private int year; // The year the book was published
    private int isbn; // The international standard book number

    // Constructor
    public Book(string bookName, string author, int year, int isbn)
    {
        this.bookName = bookName;
        this.author = author;
        this.year = year;
        this.isbn = isbn;
    }
    
    //Name getters and setters

    public string GetBookName()
    {
        return bookName;
    }

    public void SetBookName(string value)
    {
        value = bookName;
    }
    
    //Author getters and setters

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string value)
    {
        value = author;
    }
    
    //Year getters and setters

    public int GetYear()
    {
        return year;
    }

    public void SetYear(int value)
    {
        value = year;
    }
    
    //ISBN getters and setters

    public int GetIsbn()
    {
        return isbn;
    }

    public void SetIsbn(int value)
    {
        value = isbn;
    }
}