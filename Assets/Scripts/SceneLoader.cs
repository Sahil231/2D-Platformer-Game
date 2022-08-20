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
        SceneManager.LoadScene(sceneName);
    }
}
