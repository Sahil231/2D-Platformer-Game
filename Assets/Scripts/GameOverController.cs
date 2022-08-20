using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverController : MonoBehaviour
{
    public Button restartButton;
    private void Awake() {
        restartButton.onClick.AddListener(RestartLevel);  
    }
    public void OnPlayerDeath()
    {
        gameObject.SetActive(true);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
