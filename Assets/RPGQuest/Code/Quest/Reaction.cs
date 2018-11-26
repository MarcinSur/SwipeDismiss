using System;
using UnityEngine;

public abstract class Reaction : ScriptableObject
{
    public abstract void Init();
    public abstract void React();
}

[CreateAssetMenu(fileName = "Incident", menuName = "RpgQuest/QuestData/Incident", order = 1)]
public class YouLostMen : Reaction
{
    public override void Init()
    {
        throw new NotImplementedException();
    }

    public override void React()
    {
        throw new NotImplementedException();
    }
}