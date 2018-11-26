using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour {

    ScriptableObjectManagers scriptable;
    public Text gold;
    // Use this for initialization
    void Start ()
    {
        scriptable = FindObjectOfType<ScriptableObjectManagers>();
        UpdateUI();
        AddGold(5);
    }

    public void AddGold(int amount)
    {
        scriptable.goldManager.Add(amount);
        UpdateUI();
    }

    public void UpdateUI()
    {
        int i = scriptable.goldManager.Value;
        gold.text = ( $"{i}");
    }
   }
