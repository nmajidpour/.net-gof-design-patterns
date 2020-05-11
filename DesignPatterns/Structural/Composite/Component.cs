public abstract class Component
{
    protected string name;
    protected int price;
 
    public Component(string name, int price)
    {
        this.name = name;
        this.price = price;
   }
 
    public abstract int CalculateTotalPrice();
}