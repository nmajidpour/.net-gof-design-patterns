
public class AddCommand : ICommand
{
    private Calculator _calculator;
    public int Execute()
    {
        return _calculator.Add();
    }
}