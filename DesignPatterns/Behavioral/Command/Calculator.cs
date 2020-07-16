using System.Collections;
using System;

public class AddToList : ICommand
{
    private List<object> list = new List<object>();

    void Execute(object o)
    {
        list.Add(o);
    }
}