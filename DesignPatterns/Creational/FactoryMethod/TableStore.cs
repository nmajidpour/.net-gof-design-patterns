using System.Collections.Generic;

public class TableStore : FurnitureFactory
{
    public override object MakeFurniture(List<object> items)
    {
        return new Table(items);
    }
}