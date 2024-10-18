using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public static class SaveLoad {

    [System.Serializable]
    private class ScoreData {
        public List<int> scoreList;
    }

    private static int scoreDataCount;
    private static string scoreDataPath;

    static SaveLoad() {
        scoreDataCount = 10;
        scoreDataPath = Path.Combine(Application.persistentDataPath, "saves", "scores.txt");
    }

    public static void SaveScore(int score) {
        string directory = Path.GetDirectoryName(scoreDataPath);
        if (!Directory.Exists(directory)) {
            Directory.CreateDirectory(directory);
        }

        var scoreData = new ScoreData();
        scoreData.scoreList = LoadScores();
        scoreData.scoreList.Add(score);
        scoreData.scoreList.Sort((a, b) => b.CompareTo(a)); // descending order
        scoreData.scoreList = scoreData.scoreList.Take(scoreDataCount).ToList(); // keep only the top {scoreDataCount} scores

        string jsonString = JsonUtility.ToJson(scoreData);
        File.WriteAllText(scoreDataPath, jsonString);
    }

    public static List<int> LoadScores() {
        if (!File.Exists(scoreDataPath)) {
            return new List<int>();
        }

        string jsonString = File.ReadAllText(scoreDataPath);
        var scoreData = JsonUtility.FromJson<ScoreData>(jsonString);

        if (scoreData == null) {
            return new List<int>();
        }

        return scoreData.scoreList;
    }
}
