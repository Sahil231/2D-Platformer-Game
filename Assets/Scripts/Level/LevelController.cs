using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelController : MonoBehaviour
{
    public TextMeshProUGUI levelName;
    private void Awake() {
        levelName=GetComponent<TMPro.TextMeshProUGUI>();
        levelName.SetText(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("Last Played Level",SceneManager.GetActiveScene().name);
    }
}
