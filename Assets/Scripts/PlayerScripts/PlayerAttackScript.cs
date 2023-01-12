using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    public BoxCollider2D playerAttackCollider;
    private EnemyStats es;
   // public float timer = 0.1f;
    //public bool timerOn;
    private void Start()
    {
        playerAttackCollider.enabled = false;
        
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerAttackCollider.enabled = true;
            //timerOn = true;
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            playerAttackCollider.enabled = false;
        }

        // if(timerOn == true)
        // {
        //     timer -= Time.deltaTime;
        // }

        // if (timer <= 0)
        // {
        //    // playerAttackCollider.enabled = false;
        //     timer = 0.1f;
        // }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy") && playerAttackCollider.enabled == true)
        {
            //Debug.Log(other);
            other.GetComponent<EnemyStats>().enemyHealth -= 2;
        }
    }
    
}
