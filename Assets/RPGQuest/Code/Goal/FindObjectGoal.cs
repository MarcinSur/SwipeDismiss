using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FindObjectGoal", menuName = "RpgQuest/QuestData/Goal/FindObject", order = 0)]
public class FindObjectGoal: GoalData
{
    //Access to list of all fonded gameObject
    public string lostObjectName;

    public override bool CheckCompletion()
    {
        throw new NotImplementedException();
    }
}
