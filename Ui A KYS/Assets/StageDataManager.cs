using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]

public class StageResult
{
    public string playerName;
    public int stage;
    public int score;
}
[System.Serializable]

public class StageResultList
{
    public List<StageResult> results = new List<StageResult>();
}

public static class StageResultSaver
{
    private const string FILE = "stage_results.json";
    private const string PLAYER_NAME = "playerName";
    private static string filePath = path.Combine(Application.persistentDataPath, FILE);
    private static void SaveStage(int stage, int score)
    {
        if (!File.Exists(filePath))
            return new StageResultList();
        string json = File.ReadAllText(filePath);
        StageResultList list = JsonUtility.FromJson<StageResultList>(json);
        if (list == null)
            return new StageResultList();
        else
            return list;
    }

}
