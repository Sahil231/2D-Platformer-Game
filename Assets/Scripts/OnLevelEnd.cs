using UnityEngine;

public class OnLevelEnd : MonoBehaviour
{
    public LevelCompleteController levelCompleteController;
    public PlayerController playerController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>()!=null)
        {
            playerController.enabled= false;
            levelCompleteController.OnLevelComplete();
            
            /*
            nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex+1;
            if (nextSceneBuildIndex!=5)
            {
                LevelManager.Instance.setLevelStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
                LevelManager.Instance.setLevelStatus("Level "+nextSceneBuildIndex, LevelStatus.Unlocked);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
            */
        }
    }
}
