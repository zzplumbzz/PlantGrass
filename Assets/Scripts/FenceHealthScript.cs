using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceHealthScript : MonoBehaviour
{
    public int health;
    public PolygonCollider2D healthCollider;
    public float Timer = 5f;
    public bool timerOn;
    private GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
        health = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            Timer -= Time.deltaTime;
        }

        if(health <= 0 && Timer <= 0)
        {
            Debug.Log(Timer);
            Destroy(gameObject);
            gm.GetComponent<GameManagerScript>().fenceLVLCount--;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            health -= 10;
            Debug.Log("Helath down");
            timerOn = true;
        }
    }

}
