using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static GameManager Instance;
    public string pName;
    public int highScore;

    private void Awake()
    {
        if(highScore <= 0) {  highScore = 0; }
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadScore();
    }
    [System.Serializable]
    class SaveData
    {
        public string pName;
        public int highScore;
    }
    public void SaveScore() { 
        SaveData data = new SaveData();
        data.pName = pName;
        data.highScore = highScore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savescore.json" , json);
    }
    public void LoadScore() {
        string path = Application.persistentDataPath + "/savescore.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            pName = data.pName;
            highScore = data.highScore;
        }
        
    }
}
