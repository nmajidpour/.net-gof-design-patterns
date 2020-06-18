public class BakeryShopAdapter : IShop
{
    private readonly IBakery _bakery;
    
    public BakeryShopAdapter(IBakery bakery)
    {
        _bakery = bakery;
    }

    public decimal GetTotalPrice() => _bakery.CalculateTotalPrice();
}