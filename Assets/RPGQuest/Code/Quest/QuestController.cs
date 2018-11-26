using UnityEngine;

public class QuestController : MonoBehaviour
{
    public QuestData questData;
    public GoalData goalData;

    public void Progress()
    {
        goalData = ScriptableObject.CreateInstance<CountertGoal>();
        questData.goals.Add(goalData);
        Debug.Log(questData.goals[1].CheckCompletion());
    }

    public void Complete()
    {
        if (questData.incidents != null)
        {
        }
    }
}
