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
    //private GameObject ps;
    //private GameObject fss;
    public int farmCount;
    public float offsetX = -2f;
    public float offsetY = 1f;
    public bool resetLevel;

    // Start is called before the first frame update
    void Start()
    {
        
        patchArray = new GameObject[farmCount * farmCount];
        
        gm = GameObject.Find("GameManager");
        ms = GameObject.Find("MonsterSpawner");
        //ps = GameObject.Find("PlayerStats");
        //fss = GameObject.Find("GameManager");
        SpawnPatches();
        
    }

    private void Update() 
    {
        if(farmCount <= 0)
        {
            farmCount = 0;
        }
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
            if(!patchArray[i].GetComponent<PlantingPatchScript>().isNotPlanted)//if(patchArray[i].GetComponent<PlantingPatchScript>().isPlanted)
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
                gm.GetComponent<GameManagerScript>().shop1Canvas.SetActive(false);
                gm.GetComponent<GameManagerScript>().shop2Canvas.SetActive(false);
                gm.GetComponent<GameManagerScript>().gameSaved = false;
                //Destroy(ms.GetComponent<EnemySpawner>().monsterPrefab);
                //ms.GetComponent<EnemySpawner>().monsterArray.RemoveRange(0, 5);
                ms.GetComponent<EnemySpawner>().monsterPrefab.transform.position = new Vector3(UnityEngine.Random.Range(0f, 38f), UnityEngine.Random.Range(-32f, 30f), -0.1f);
                Time.timeScale = 1;
                gm.GetComponent<GameManagerScript>().player.transform.position = new Vector3(-9f, -0.15f, -0.1f);
                gm.GetComponent<GameManagerScript>().playerHUD.SetActive(true);
                
                int count = ms.GetComponent<EnemySpawner>().monsterArray.Count;//added all this with // behind
                for (int m = 0; m < count; m++)//
                {//
                    Destroy(ms.GetComponent<EnemySpawner>().monsterArray[0]);//
                    ms.GetComponent<EnemySpawner>().monsterArray.RemoveAt(0);//
                }//

                if(gm.GetComponent<GameManagerScript>().levelCount >= 10)
                {
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesBottom1();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesTop1();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesRight1();
                }

                if (gm.GetComponent<GameManagerScript>().levelCount >= 20)
                {
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesBottom2();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesTop2();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesRight2();
                }

                if (gm.GetComponent<GameManagerScript>().levelCount >= 30)
                {
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesBottom3();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesTop3();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesRight3();
                }

                if (gm.GetComponent<GameManagerScript>().levelCount >= 40)
                {
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesBottom4();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesTop4();
                    gm.GetComponent<FenceSpawningScript>().SpawnFencesRight4();
                }


            }



        //}
    }
        
}
