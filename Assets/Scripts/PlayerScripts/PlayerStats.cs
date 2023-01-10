using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{   
    
    public float playerHealth;
    public float playerMaxHealth = 10f;
    public HealthBarScript healthBar;
    private GameObject es;

    // Start is called before the first frame update
    void Start()
    {
        es = GameObject.Find("Enemy");
        playerHealth = playerMaxHealth;
        //healthBar.SetMaxHealth(playerMaxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
        
        //Debug.Log(playerHealth);
        if(playerHealth <= 0)
        {

           
            Time.timeScale = 0;
            
            

        }
    }

    
}
