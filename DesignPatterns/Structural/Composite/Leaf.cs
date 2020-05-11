public class Leaf : Component
{
    public Leaf(string name, int price)
      : base(name, price)
    {
    }

    public override int CalculateTotalPrice()
    {
       return price;
    }
}