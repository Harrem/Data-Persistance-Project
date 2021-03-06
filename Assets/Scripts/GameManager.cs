using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int bestscore;
    public int score;
    public string userName;

    private Serializations saveData;

    private void Start()
    {
        SetupGameManager();
        saveData = GetComponent<Serializations>();
        saveData.Load();
    }
    

    private void SetupGameManager()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    private void OnDestroy()
    {
        saveData.Save();
    }
}
