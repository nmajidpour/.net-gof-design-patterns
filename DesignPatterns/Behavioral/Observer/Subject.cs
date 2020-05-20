using System.Collections;
using System.Collections.Generic;

public class Subject
{
    private List<Observer> observerList = new List<Observer>();

    public void Add(Observer observer)
    {
        if (!observerList.Contains(observer))
            observerList.Add(observer);
    }

    public void Notify()
    {
        foreach (Observer o in observerList)
        {
            o.Update();
        }
    }
}