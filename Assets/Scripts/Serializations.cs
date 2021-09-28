using System.IO;
using System;
using UnityEngine;

public class Serializations : MonoBehaviour
{
    public void Save()
    {
        var data = new Data();
        data.username = GameManager.instance.userName;
        data.bestScore = GameManager.instance.bestscore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/data.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/data.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            var data = JsonUtility.FromJson<Data>(json);
            GameManager.instance.bestscore = data.bestScore;
            GameManager.instance.userName = data.username;
        }
    }

    [Serializable]
    class Data
    {
        public string username;
        public int bestScore;
    }
}
