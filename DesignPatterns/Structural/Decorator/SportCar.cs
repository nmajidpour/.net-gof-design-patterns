using System.Collections.Generic;

// Any type of car can be pass to this class and become a sport car with more price
public class SportCar : ICar
{
    private readonly ICar _decoratedCar;
    public SportCar(ICar decoratorCar)
    {
        _decoratedCar = decoratorCar;
        Price += 500;
        _decoratedCar.Components.ForEach(c => Components.Add(c));
        Components.Add("Sport Wheels");
    }

    public int Price { get; set; }
    public List<string> Components { get; set; } = new List<string>();
    public void Assemble()
    {
        // Assemble Sport car
    }
}