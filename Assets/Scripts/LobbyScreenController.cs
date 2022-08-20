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
        if(PlayerPrefs.GetString("Last Played Level")==null)
        Debug.Log("space");
    }
    private void StartGame()
    {
        if(PlayerPrefs.GetString("Last Played Level")=="")
        PlayerPrefs.SetString("Last Played Level","Level 1");
        SceneManager.LoadScene(PlayerPrefs.GetString("Last Played Level"));
    }
}
