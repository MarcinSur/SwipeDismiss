using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quest", menuName = "RpgQuest/QuestData/Quest", order = 0)]
public class QuestData :ScriptableObject {

    public int id;
    public int hash { get; }
    public string title;
    public string decription;
    public List<GoalData> goals;
    public List<Reaction> incidents;
}
