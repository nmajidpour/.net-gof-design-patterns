public class Invoker
{
    private ICommand command;
    public void DoExecute()
    {
        command.Execute();
    }
}