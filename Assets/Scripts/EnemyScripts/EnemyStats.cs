using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public float enemyHealth = 8f;
    public GameObject enemyPrefab;
    public PlayerStats ps;
    public HealthBarScript healthBar;
    private GameObject player;
    public bool playerTakesDamage;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Square");
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Debug.Log("Enemy Dead");
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PSprite"))
        {
            playerTakesDamage = true;
            other.GetComponent<PlayerStats>().playerHealth -= 2;
            //healthBar.SetHealth(player.GetComponent<PlayerStats>().playerHealth);
           // gameObject.GetComponent<PlayerStats>().SetHealth(ps.GetComponent<PlayerStats>().playerHealth);
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.CompareTag("PSprite"))
        {
            playerTakesDamage = false;
        }
    }
    
}
