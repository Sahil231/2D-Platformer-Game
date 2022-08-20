using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLevelEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>()!=null)
        {
            if (SceneManager.GetActiveScene().buildIndex+1!=5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
