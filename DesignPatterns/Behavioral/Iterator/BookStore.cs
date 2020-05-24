using System.Collections;
using System;

public class BookStore
{
    Inventory inventory = new Inventory();
   public void DisplayInventory(){
        foreach(Book b in inventory)
        {
             Sell(b);
        }
    }
    private void Sell(Book book)
    {
        // Todo sell function
    }

    private void AddBook(Book b)
    {
        inventory.Add(b);
    }

    private void RemoveBook(Book b)
    {
        inventory.Add(b);
    }
}
