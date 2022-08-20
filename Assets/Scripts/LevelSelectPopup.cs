using UnityEngine;
using UnityEngine.UI;

public class LevelSelectPopup : MonoBehaviour
{
   public Button button;
   public GameObject levelSelectPopup;
    // Start is called before the first frame update
    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);
    }

    void onClick()
    {
        levelSelectPopup.SetActive(true);
    }
}
