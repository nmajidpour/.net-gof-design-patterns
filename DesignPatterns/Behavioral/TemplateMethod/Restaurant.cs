// Template method pattern provides skeleton for calling the sequence methods
// implementation of some of the method can be deferred to the subclasses 
// without changing order of calls
public abstract class Restaurant
{
    object food;
    public object CreateFoodForDelivery()
    {
        TakeOrder();
        ProcessPayment();
        CookFood();
        DeliverFood();
        return food;
    }

    public abstract void TakeOrder();
    public abstract void CookFood();
    public abstract void ProcessPayment();
    internal void DeliverFood()
    {
        // Deliver food to customer
    }
    
}