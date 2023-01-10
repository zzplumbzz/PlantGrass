using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnPatchScript : MonoBehaviour
{
    public GameObject[] patchArray;
    public GameObject patch;
    private GameObject tempGO;
    public Sprite patchS;
    public Sprite plantedPatchS;
    public SpriteRenderer sr;
    private GameObject gm;
    private GameObject ms;
    private GameObject ps;
    public int farmCount;
    public float offsetX = -0.5f;
    public float offsetY = 0.5f;
    public bool resetLevel;

    // Start is called before the first frame update
    void Start()
    {
        
        patchArray = new GameObject[farmCount * farmCount];
        
        gm = GameObject.Find("GameManager");
        ms = GameObject.Find("MonsterSpawner");
        ps = GameObject.Find("PlayerStats");
        SpawnPatches();
        
    }

    public void SpawnPatches()
    {
        
        for (int y = 0; y < farmCount; y++)
        {


            for (int x = 0; x < farmCount; x++)
            {
                var currentIndex = farmCount * y + x;
                var newPosition = new Vector3(offsetX + x, offsetY - y, -0.01f);
                
                if (patchArray[currentIndex] == null)
                {   
                    tempGO = Instantiate(patch, newPosition, Quaternion.identity);
                    patchArray[currentIndex] = tempGO;
                }
               else
               {
                    patchArray[currentIndex].transform.position = newPosition;
               }
                
                
            }

        }
    }

    public Transform ActivatedPatch()
    {
        for(int i = 0; i <patchArray.Length; i++)
        {
            if(patchArray[i].GetComponent<PlantingPatchScript>().isNotPlanted)//if(patchArray[i].GetComponent<PlantingPatchScript>().isPlanted)
            {
                return patchArray[i].transform;
            }
            
        }
        return null;
    }

    public void ResetLevel()
    {
        //resetLevel = true;
        //if(resetLevel == true)
        //{
            Array.Resize(ref patchArray, farmCount * farmCount);

            SpawnPatches();
            for (int i = 0; i < patchArray.Length; i++)
            {

                patchArray[i].GetComponent<SpriteRenderer>().sprite = patchArray[i].GetComponent<PlantingPatchScript>().patchS;
                patchArray[i].GetComponent<PlantingPatchScript>().isNotPlanted = true;//patchArray[i].GetComponent<PlantingPatchScript>().isPlanted = false;
                gm.GetComponent<GameManagerScript>().winCanvas.SetActive(false);
                gm.GetComponent<GameManagerScript>().winTrue = false;
                //Destroy(ms.GetComponent<EnemySpawner>().monsterPrefab);
                ms.GetComponent<EnemySpawner>().monsterPrefab.transform.position = new Vector3(UnityEngine.Random.Range(0f, 38f), UnityEngine.Random.Range(-32f, 30f), -0.1f);
                Time.timeScale = 1;
                gm.GetComponent<GameManagerScript>().player.transform.position = new Vector3(-9f, -0.15f, -0.1f);
                gm.GetComponent<GameManagerScript>().playerParent.transform.position = new Vector3(-9f, -0.15f, -0.1f);
            }



        //}
    }
        
}