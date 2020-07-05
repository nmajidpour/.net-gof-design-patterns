using System.Collections.Generic;

public class SofaStore : FurnitureFactory
{
    public override object MakeFurniture(List<object> items)
    {
        return new Sofa(items);
    }
}