public class Book
{
    private string name;
    private int price;

    public Book(string bookname, int bookprice)
    {
        name = bookname;
        price = bookprice; 
    }

    public string GetBookName
    {
        get
        {
            return name;
        } 
        set
        {
            value = name;
        }
    }

    public int GetBookPrice
    {
        get
        {
            return price;
        } 
        set
        {
            value = price;
        }
    }
}