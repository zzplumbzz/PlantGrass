using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceHealthScript : MonoBehaviour
{
    public int health;
    public PolygonCollider2D healthCollider;
    public float Timer = 5f;
    public float SFTimer = 10f;
    public bool timerOn;
    public bool SFTimerOn;
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

        if(SFTimerOn == true)
        {
            SFTimer -= Time.deltaTime;
        }

        if(health <= 0 && Timer <= 0 && gm.GetComponent<GameManagerScript>().SFHouseSet == false)
        {
            Debug.Log(Timer);
            Destroy(gameObject);
            //gm.GetComponent<GameManagerScript>().fenceLVLCount--;
        }

        if (health <= 0 && Timer <= 0 && gm.GetComponent<GameManagerScript>().SFHouseSet == true)
        {
            Debug.Log(Timer);
            Destroy(gameObject);
            //gm.GetComponent<GameManagerScript>().fenceLVLCount--;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            health -= 10;
            Debug.Log("Helath down");
            if(gm.GetComponent<GameManagerScript>().SFHouseSet == false)
            {
                timerOn = true;
            }
            if (gm.GetComponent<GameManagerScript>().SFHouseSet == true)
            {
                SFTimerOn = true;
            }
            
        }
    }

}
