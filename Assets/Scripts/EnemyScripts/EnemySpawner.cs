using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public GameObject monsterPrefab;
    public List<GameObject> monsterArray;
    public GameObject tempGO;
    public float Timer = 20f;
    public bool enemySpawned;
    public bool timerOn;
    private GameObject gm;
    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
        enemySpawned = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            Timer -= Time.deltaTime;
        }

        if(gm.GetComponent<GameManagerScript>().levelCount == 5)
        {
            timerOn = true;
        }
        
        
        if(Timer <= 0 && gm.GetComponent<GameManagerScript>().levelCount >= 5 &&gm.GetComponent<GameManagerScript>().levelCount <= 11)
        {
            enemySpawned = true;
            SpawnMonstersBottomLVL1();
            SpawnMonstersTopLVL1();
            Timer = 20;
            timerOn = true;
        }

        if (Timer <= 0 && gm.GetComponent<GameManagerScript>().levelCount >= 12 && gm.GetComponent<GameManagerScript>().levelCount <= 25)
        {
            enemySpawned = true;
            SpawnMonstersBottomLVL2();
            SpawnMonstersTopLVL2();
            Timer = 20;
            timerOn = true;
        }

        if (Timer <= 0 && gm.GetComponent<GameManagerScript>().levelCount >= 25)
        {
            enemySpawned = true;
            SpawnMonstersBottomLVL3();
            SpawnMonstersTopLVL3();
            Timer = 20;
            timerOn = true;
        }

       
    }

    

    public void SpawnMonstersBottomLVL1()
    {

        for (int i = 0; i < 1; i++)
        {
            tempGO = Instantiate(monsterPrefab, new Vector3(Random.Range(0f, 19f), Random.Range(-10f, -12f), -0.1f), Quaternion.identity);
            monsterArray.Add(tempGO);

        }
    }

    public void SpawnMonstersTopLVL1()
    {

        for (int i = 0; i < 1; i++)
        {
            tempGO = Instantiate(monsterPrefab, new Vector3(Random.Range(0f, 19f), Random.Range(10f, 12f), -0.1f), Quaternion.identity);
            monsterArray.Add(tempGO);

        }
    }

    public void SpawnMonstersBottomLVL2()
    {

        for (int i = 0; i < 1; i++)
        {
            tempGO = Instantiate(monsterPrefab, new Vector3(Random.Range(0f, 29f), Random.Range(-21f, -25f), -0.1f), Quaternion.identity);
            monsterArray.Add(tempGO);

        }
    }

    public void SpawnMonstersTopLVL2()
    {

        for (int i = 0; i < 1; i++)
        {
            tempGO = Instantiate(monsterPrefab, new Vector3(Random.Range(0f, 29f), Random.Range(21f, 24f), -0.1f), Quaternion.identity);
            monsterArray.Add(tempGO);

        }
    }

    public void SpawnMonstersBottomLVL3()
    {

        for (int i = 0; i < 1; i++)
        {
            tempGO = Instantiate(monsterPrefab, new Vector3(Random.Range(0f, 37f), Random.Range(-29f, -32f), -0.1f), Quaternion.identity);
            monsterArray.Add(tempGO);

        }
    }

    public void SpawnMonstersTopLVL3()
    {

        for (int i = 0; i < 1; i++)
        {
            tempGO = Instantiate(monsterPrefab, new Vector3(Random.Range(0f, 37f), Random.Range(29f, 32f), -0.1f), Quaternion.identity);
            monsterArray.Add(tempGO);

        }
    }

    
}
