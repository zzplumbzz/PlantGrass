using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlantingPatchScript : MonoBehaviour
{
    public Sprite patchS;
    public Sprite plantedPatchS;
    public SpriteRenderer sr;
    public Transform plantedPatchP;
    public bool isNotPlanted;
    //public bool isPlanted;
    public GameObject gms2;
    private SpawnPatchScript sps;
    

    // Start is called before the first frame update
    void Start()
    {
        isNotPlanted = true;
        //isPlanted = false;
       gms2 = GameObject.Find("GameManager");
        
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("PSprite") && isNotPlanted == true && Input.GetKey(KeyCode.LeftShift))
        {
            PlantPatch(true);
            isNotPlanted = false;
            gms2.GetComponent<GameManagerScript>().plusOneCounted++;

        }

        if (other.CompareTag("Enemy") && isNotPlanted == false)
        {
            DestroyPatch(true);
            gms2.GetComponent<GameManagerScript>().plusOneCounted--;

        }
        // if (other.CompareTag("PSprite") && isPlanted == false)
        // {
        //     PlantPatch(true);
        //     isNotPlanted = false;
        //     gms2.GetComponent<GameManagerScript>().plusOneCounted++;

        // }

        // if(other.CompareTag("Enemy") && isPlanted == true)
        // {
        //     DestroyPatch(true);
        //     gms2.GetComponent<GameManagerScript>().plusOneCounted--;
            
        // }
    }

    private void PlantPatch(bool newState)
    {
        isNotPlanted = newState;
        sr.sprite = (isNotPlanted) ? plantedPatchS : patchS;

    }

    private void DestroyPatch(bool newState)
    {
        isNotPlanted = newState;
        sr.sprite = (isNotPlanted) ? patchS : plantedPatchS;
        //isPlanted = false;
    }

    // private void PlantPatch(bool newState)
    // {
    //     isPlanted = newState;
    //     sr.sprite = (isPlanted) ? plantedPatchS : patchS;
        
    // }

    // private void DestroyPatch(bool newState)
    // {
    //     isNotPlanted = newState;
    //     sr.sprite = (isNotPlanted) ? patchS : plantedPatchS;
    //     isPlanted = false;
    // }
}
