using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance {get {return instance;}}
    void Awake() {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if(getLevelStatus("Level 1")==LevelStatus.Locked)
        {
            setLevelStatus("Level 1",LevelStatus.Unlocked);
        }
    }
    public void LoadAnyLevel(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }

    public LevelStatus getLevelStatus(string level)
    {
        LevelStatus levelStatus = (LevelStatus)PlayerPrefs.GetInt(level, 0);
        return levelStatus;
    }

    public void setLevelStatus(string level, LevelStatus levelStatus)
    {
        PlayerPrefs.SetInt(level, (int)levelStatus);
    }
}
