using System.Collections.Generic;

public abstract class FurnitureFactory
{
    public object OrderFurniture(List<object> objects)
    {
        object furniture = MakeFurniture(objects);
        Ship();

        return furniture;
    }

    public abstract object MakeFurniture(List<object> items);
    internal void Ship()
    {
        // Send it to the customer
    }
}