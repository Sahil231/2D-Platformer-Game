using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Button button;
    private void Awake() {
        button.onClick.AddListener(RestartLevel);   
    }
    public void OnPlayerDeath()
    {
        gameObject.SetActive(true);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
