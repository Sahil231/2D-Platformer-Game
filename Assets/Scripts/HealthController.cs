using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthController : MonoBehaviour
{
    private TextMeshProUGUI tmp;
    private PlayerController playerController; 
    int health;

    void Start()
    {
        tmp= gameObject.GetComponent<TextMeshProUGUI>();
        playerController= GameObject.Find("Player").GetComponent<PlayerController>();
        health= 3;
        RenderUI();
    }
    public void TakeDamage()
    {
        health-=1;
        if(health==0)
        {
            playerController.KillPlayer();
        }
        RenderUI();
    }
    private void RenderUI(){
        tmp.text= "Health : "+ health;
    }
}
