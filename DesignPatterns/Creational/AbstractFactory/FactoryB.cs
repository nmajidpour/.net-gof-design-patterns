// Concrete factory B
public class FactoryB : ShoeFactory
{
    public override Sandal MakeSandal()
    {
        return new WedgeSandal();
    }
    public override Boot MakeBoot()
    {
        return new WedgeBoot();
    }
}