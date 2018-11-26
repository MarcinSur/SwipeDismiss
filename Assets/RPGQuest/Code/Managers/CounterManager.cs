using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class CounterManager : ScriptableObject
{

    public List<int> list = new List<int>();
    public int value;
    public UnityEvent addedToListEvent;
    public UnityEvent removeFromListEvent;
}

[CreateAssetMenu(fileName = "CounterManager", menuName = "RpgQuest/Managers/CounterManager", order = 0)]
public class GoldManager : CounterManager, IManager<int>
{
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }

    public void Add(int amount)
    {
        list.Add(amount);
        Value += amount;
        if (addedToListEvent != null)
            addedToListEvent.Invoke();
    }

    public void Remove(int amount)
    {
        list.Remove(amount);
        Value -= amount;
        if (removeFromListEvent != null)
            removeFromListEvent.Invoke();
    }
}