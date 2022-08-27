using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelCompleteController : MonoBehaviour
{
    public Button restartButton;
    public Button nextLevel;
    private int nextSceneBuildIndex;

    private void Awake() {
        restartButton.onClick.AddListener(RestartLevel);  
        nextLevel.onClick.AddListener(NextLevel);
    }
    public void OnLevelComplete()
    {
        gameObject.SetActive(true);
        LevelManager.Instance.setLevelStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void NextLevel()
    {
        nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex+1;
        if (nextSceneBuildIndex!=5)
        {
            LevelManager.Instance.setLevelStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
            LevelManager.Instance.setLevelStatus("Level "+nextSceneBuildIndex, LevelStatus.Unlocked);
            LevelManager.Instance.LoadAnyLevel(SceneManager.GetActiveScene().buildIndex+1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}

