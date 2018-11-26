using UnityEngine;

[CreateAssetMenu(fileName = "CountertGoal", menuName = "RpgQuest/QuestData/Goal/Counter", order = 1)]
public class CountertGoal : GoalData
{
    public CounterManager counterManager;
    public int counter;

    public void DecreaceCounter(int amount)
    {
        counter -= amount;
    }

    public override bool CheckCompletion()
    {
        return counter <= 0;
    }
}
