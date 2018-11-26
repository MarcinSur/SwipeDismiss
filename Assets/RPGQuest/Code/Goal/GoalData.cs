using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum GoalType
{
    Boolean,
    Counter,
    CountDown,
    FindObject,
    FindObjects
}

public abstract class GoalData :ScriptableObject {

    public int id;
    public GoalType goalType;
    public string title;
    public string desc;

    public abstract bool CheckCompletion();
}
