using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyScreenController : MonoBehaviour
{
    public Button startButton;
    private void Awake() {
        startButton.onClick.AddListener(StartGame);  
    }
    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
