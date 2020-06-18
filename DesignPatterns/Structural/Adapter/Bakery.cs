public class Bakery : IBakery
{
    private decimal _cakePrice;
    private int _numberOfCakes; 
    private decimal _servicePrice = 0.50m;
    
    public Bakery(int numberOfCakes, decimal cakePrice)
    {
        _cakePrice = cakePrice;
        _numberOfCakes = numberOfCakes;
    }

    public decimal CalculateTotalPrice()
    {
        return _cakePrice * _numberOfCakes * _servicePrice;
    }
}