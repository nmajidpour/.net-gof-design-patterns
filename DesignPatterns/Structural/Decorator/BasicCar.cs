using System.Collections.Generic;

public class BasicCar : ICar
{
    public BasicCar()
    {
        Price = 10000;
        Components.Add("Basic Wheels");
        Components.Add("Gear");
    }

    public int Price { get; set; }
    public List<string> Components { get; set; } = new List<string>();
    public void Assemble()
    {
        // Assemble basic car
    }
}