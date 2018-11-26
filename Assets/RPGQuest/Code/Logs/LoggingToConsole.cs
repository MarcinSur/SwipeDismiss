using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class Logging {

    public static string savePath = Application.persistentDataPath + "/game_save";
    private static string messages;

    public static void ToConsoleMessage(object s)
    {
        messages = "";
        messages = s.ToString();
        Debug.Log(s);
        SaveToFile();
    }

    public static void SaveToFile()
    {
        if (!Directory.Exists(savePath))
            Directory.CreateDirectory(savePath);

        FileStream fs = new FileStream(savePath + "/logs.txt", FileMode.Append);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(messages);
        sw.Close();
        fs.Close();
    }
}
