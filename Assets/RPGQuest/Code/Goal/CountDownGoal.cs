using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CountDown", menuName = "RpgQuest/QuestData/Goal/CountDown", order = 2)]
public class CountDownGoal : GoalData
{
    public int countDown;

    public override bool CheckCompletion()
    {
        throw new NotImplementedException();
    }
}