using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecretChestScript : MonoBehaviour
{
   // public GameObject chest;
    public GameObject gms;
    public bool isOpen;
    public bool chestTXTTrue;

    public SpriteRenderer ChestClosed;
    public SpriteRenderer ChestOpened;

    private void Start() 
    {
        gms = GameObject.Find("GameManager");
    }
    
    private void Update()   
    {

        if(isOpen == false)
        {
            ChestClosed.enabled = true;
            ChestOpened.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Q) && chestTXTTrue == true && isOpen == false)
        {
            isOpen = true;
            gms.GetComponent<GameManagerScript>().money += 1000;
            ChestClosed.enabled = false;
            ChestOpened.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("PSprite") && isOpen == false)
        {
            chestTXTTrue = true;
            gms.GetComponent<GameManagerScript>().ChestText.enabled = true;
            gms.GetComponent<GameManagerScript>().BGChest.enabled = true;

            
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        chestTXTTrue = false;
        gms.GetComponent<GameManagerScript>().ChestText.enabled = false;
        gms.GetComponent<GameManagerScript>().BGChest.enabled = false;
    }
}
