// Concrete factory A
public class FactoryA : ShoeFactory
{
    public override Sandal MakeSandal()
    {
        return new FlatSandal();
    }
    public override Boot MakeBoot()
    {
        return new FlatBoot();
    }
}