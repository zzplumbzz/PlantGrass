using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    

    public GameObject patch;
    public GameObject plantedPatch;
   
    

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Instantiate(plantedPatch, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            gameObject.SetActive(false);
            Debug.Log("patch planted = true!");
            
        }
    }
}
