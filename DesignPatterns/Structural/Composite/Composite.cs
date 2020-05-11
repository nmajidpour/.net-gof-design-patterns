using System.Collections.Generic;

public class Composite : Component, IComponent
  {
    private List<Component> componentList;
 
    public Composite(string name, int price)
      : base(name, price)
    {
       componentList = new List<Component>();
    }

    public void Add(Component component)
    {
        componentList.Add(component);
    }

    public void Remove(Component component)
    {
        componentList.Remove(component);
    }

    public override int CalculateTotalPrice()
    {
        int total = 0;
  
        foreach (var component in componentList)
        {
            total += component.CalculateTotalPrice();
        }
 
        return total;
    }
}