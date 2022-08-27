using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    Button button;
    public string sceneName;
    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);
    }

    void onClick()
    {
        if(sceneName=="LobbyScreen")
        SceneManager.LoadScene(sceneName);
        else{
            LevelStatus levelStatus = LevelManager.Instance.getLevelStatus(sceneName);
            switch(levelStatus)
            {
                case LevelStatus.Locked:
                    Debug.Log("Level Is Locked");
                    break;
                case LevelStatus.Unlocked:
                    SceneManager.LoadScene(sceneName);
                    break;
                case LevelStatus.Completed:
                    SceneManager.LoadScene(sceneName);
                    break;
            }
        }
    }
}
