using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDatabase : MonoBehaviour, IDataAccess<QuestData>
{
    [SerializeField]
    public Dictionary<int, QuestData> quests = new Dictionary<int, QuestData>();

    public void AddData(QuestData data)
    {
        quests.Add(data.id, data);
        Logging.ToConsoleMessage(data.hash);
    }

    public QuestData GetData(int id)
    {
        QuestData quest;
        quests.TryGetValue(id, out quest);
        return quest;
    }
}
