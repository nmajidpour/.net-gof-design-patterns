using System.Collections.Generic;
using System.Linq;

public class Inventory : IEnumerator<object>
{
    List<Book> bookList = new List<Book>();
    int current = 0;

    public void Add(Book book)
    {
        bookList.Add(book);
    }

    public void Remove(Book book)
    {
        bookList.Remove(book);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return bookList.GetEnumerator();
    }
    public object Current
    {
        get 
        {
            return bookList.ElementAt(current); 
        }
    }

    public bool MoveNext()
    {
        return true;
    }
    public void Reset()
    {
    }
    
    public void Dispose()
    {
        //Dispose here
    }
}