using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Button restartButton;
    public Button quitButton;
    private void Awake() {
        restartButton.onClick.AddListener(RestartLevel);  
        quitButton.onClick.AddListener(Quit);
    }
    public void OnPlayerDeath()
    {
        gameObject.SetActive(true);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }
    private void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
