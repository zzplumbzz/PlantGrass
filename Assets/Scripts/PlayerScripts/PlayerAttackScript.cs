using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    public BoxCollider2D playerAttackCollider;
    private EnemyStats es;
    public AudioSource attackSound;
    public Animator animator;
    public bool isAttacking;
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
            isAttacking = true;
            playerAttackCollider.enabled = true;
            
            attackSound.Play();
            //timerOn = true;
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            isAttacking = false;
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
