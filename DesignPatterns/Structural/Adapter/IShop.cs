// All adapter classes (differnt kind of shops in this example BakeryShopAdapter) 
// can implement this interface to apply adapter design pattern
interface IShop
{
    decimal GetTotalPrice();
}