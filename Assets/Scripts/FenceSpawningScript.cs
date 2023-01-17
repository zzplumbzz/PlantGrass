using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceSpawningScript : MonoBehaviour
{
    public GameObject fencePrefab;
    public GameObject spawnedFence;
    public GameObject sideFencePrefab;
    public List<GameObject> fenceArray {get; private set; } = new List<GameObject>();
    public GameObject[] fenceArrayN;
    public GameObject tempGO;
    public bool fenceIsActive;
    public int farmCount2;


    private void Start() 
    {
       

    }

    public void SpawnCurrentFences()
    {
        
        //patchArray[i].GetComponent<SpriteRenderer>().sprite = patchArray[i].GetComponent<PlantingPatchScript>().patchS;
    }
    
    

    public void SpawnFencesTop1()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {
            for (int x = 0; x < 7; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 1f - y, -0.1f), Quaternion.identity);
                //fenceArray.Add(Instantiate(fencePrefab));
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesTop2()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 11; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 5f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesTop3()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 18; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 9f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesTop4()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 12f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesTop5()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 15f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesTop6()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 19f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesTop7()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 21f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }
    public void SpawnFencesTop8()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 25f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesTop9()//(-3.499f, 2.5f), 2.5f, -0.1f)
    {

        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, 29f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesRight1()
    {
        for (int y = 0; y < 3; y++)
        {


            for (int x = 0; x < 1; x++)
            {
                spawnedFence = Instantiate(sideFencePrefab, new Vector3(6.15f + x, 0.5f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesRight2()
    {
        for (int y = 0; y < 10; y++)
        {


            for (int x = 0; x < 1; x++)
            {
                spawnedFence = Instantiate(sideFencePrefab, new Vector3(10.11f + x, 4.5f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesRight3()
    {
        for (int y = 0; y < 16; y++)
        {


            for (int x = 0; x < 1; x++)
            {
                spawnedFence = Instantiate(sideFencePrefab, new Vector3(17f + x, 7.41f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesRight4()
    {
        for (int y = 0; y < 31; y++)
        {


            for (int x = 0; x < 1; x++)
            {
                spawnedFence = Instantiate(sideFencePrefab, new Vector3(23f + x, 14.41f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesRight5()
    {
        for (int y = 0; y < 31; y++)
        {


            for (int x = 0; x < 1; x++)
            {
                spawnedFence = Instantiate(sideFencePrefab, new Vector3(30f + x, 14.41f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom1()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 7; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -2f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom2()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 11; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -5f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom3()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 18; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -13.976f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom4()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -9f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom5()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -12f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom6()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -16f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom7()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -21f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom8()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -25f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }

    public void SpawnFencesBottom9()
    {
        for (int y = 0; y < 1; y++)
        {


            for (int x = 0; x < 38; x++)
            {
                spawnedFence = Instantiate(fencePrefab, new Vector3(-0.5f + x, -29f - y, -0.1f), Quaternion.identity);
                fenceArray.Add(tempGO);
            }

        }
    }
}
