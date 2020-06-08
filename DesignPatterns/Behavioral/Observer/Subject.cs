using System.Collections;
using System.Collections.Generic;

public abstract class Subject
{
    private List<Observer> observerList = new List<Observer>();

    public void AddObservers(Observer observer)
    {
        if (!observerList.Contains(observer))
            observerList.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (Observer o in observerList)
        {
            o.Update();
        }
    }
}