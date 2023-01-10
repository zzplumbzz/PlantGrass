using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManagerScript : MonoBehaviour
{
    
    public GameObject winCanvas;
    public GameObject pauseCanvas;
    public GameObject mainMenuCanvas;
    public GameObject newGamecanvas;
    public GameObject optionsCanvas;
    public GameObject audioCanvas;
    public GameObject creditsCanvas;
    public GameObject playerHUD;
    public bool mainMenuTrue;
    public Button purchasePatchButton;
    public Button purchaseFenceButton;
    public Button refillHealthButton;
    public int plusOneCounted;
    public TMP_Text patchCount;
    public TMP_Text moneyCount;
    public TMP_Text moneyCountWS;
    public int money;
    public int moneyWS;
    public TMP_Text HealthWS;
    private FenceSpawningScript fss;
    private EnemySpawner ess;
    private PlayerStats ps;
    public GameObject patchClone;
    public GameObject enemyClone;
    public bool winTrue;
    private GameObject sps;
    public GameObject player;
    public GameObject playerParent;
    public GameObject patchSpawner;
    public GameObject plantPatcher;
    public GameObject ms;
    public float fenceLVLCount;
    public int patchButtonInt;
    public int amountNeededFP;
    public int amountNeededFF;
    public TMP_Text amountNeededPTXT;
    public TMP_Text amountNeededFTXT;
    public TMP_Text amountNeededHTXT;
    public GameObject amountNeededTXTBG;
    public TMP_Text playerHealthTXT;
    public float playersHealth;
    public int levelCount;
    

    // Start is called before the first frame update
    void Start()
    {
        
      
        mainMenuCanvas.SetActive(true);
        mainMenuTrue = true;
        winCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        playerHUD.SetActive(false);
        optionsCanvas.SetActive(false);
        audioCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        newGamecanvas.SetActive(false);
        plusOneCounted = 0;
        //fenceLVLCount = 0f;
        winTrue = false;
        sps = GameObject.Find("ChangingPatches");
        Time.timeScale = 1;
        patchButtonInt = 0;
        amountNeededFP = 20;
        amountNeededFF = 25;
        
    }

    private void Update() 
    {
        //Debug.Log(levelCount);
       // money = 1000000;
        if(mainMenuTrue == true)
        {
            winCanvas.SetActive(false);
            pauseCanvas.SetActive(false);
            playerHUD.SetActive(false);
            Time.timeScale = 0;
        }
       // Debug.Log(fenceLVLCount);
        //Mathf.Clamp(fenceLVLCount, 0f, 21f);

        if(fenceLVLCount <= 0f)
        {
            fenceLVLCount = 0f;
        }
        
        //playersHealth = GetComponent<PlayerStats>().playerHealth;
        patchCount.SetText(plusOneCounted.ToString());
        moneyCount.SetText(money.ToString());
        moneyCountWS.SetText(money.ToString());
        HealthWS.SetText(player.GetComponent<PlayerStats>().playerHealth.ToString());
        amountNeededPTXT.SetText("You Need " + "$" + amountNeededFP.ToString() + " To purchase more Patches.");
        amountNeededFTXT.SetText("You Need " + "$" + amountNeededFF.ToString() + " To purchase more Fences.");
        amountNeededHTXT.SetText("You Need $15 to Replenish Your Health.");
        playerHealthTXT.SetText(player.GetComponent<PlayerStats>().playerHealth.ToString());
        UpdateAmountNeededForPatches();

        if (patchButtonInt >= 14)
        {
            purchasePatchButton.enabled = false;
        }

        if(fenceLVLCount <= 20f)
        {
            purchaseFenceButton.enabled = true;
        }
        else if (fenceLVLCount >= 21f)
        {

            purchaseFenceButton.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.P))//&& winCanvas.active == false
        {
            pauseCanvas.SetActive(true);
            playerHUD.SetActive(false);

            Time.timeScale = 0;
        }

        if(winTrue == true)
        {
            pauseCanvas.SetActive(false);
        }

        

        if (plusOneCounted >= sps.GetComponent<SpawnPatchScript>().patchArray.Length && winTrue == false)
        {
            winTrue = true;
            winCanvas.SetActive(true);
            plusOneCounted = 0;
            Time.timeScale = 0;
            money += sps.GetComponent<SpawnPatchScript>().patchArray.Length;
            levelCount += 1;
        }

        
        

        
    }

    

    public void PurchasePatchButtonPressed()
    {
        Debug.Log(patchButtonInt);

        if(money != amountNeededFP)
        {
            amountNeededTXTBG.SetActive(true);
        }

        if (money >= amountNeededFP)
        {
            patchButtonInt += 1;
            money -= amountNeededFP;
            sps.GetComponent<SpawnPatchScript>().farmCount += 2;
            sps.GetComponent<SpawnPatchScript>().offsetY += 1f;
            
        }

        
    }

    

    public void ResumeButtonPressed()
    {
        pauseCanvas.SetActive(false);
        playerHUD.SetActive(true);
        Time.timeScale = 1;
        
    }

    public void PurchaseButtonPressed()
    {
        if (money >= 25 && fenceLVLCount == 0f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop1();

        }
        else if (money >= 25 && fenceLVLCount == 1f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom1();
        }
        else if (money >= 25 && fenceLVLCount == 2f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesRight1();
        }
        else if (money >= 25 && fenceLVLCount == 3f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop2();
        }
        else if (money >= 25 && fenceLVLCount == 4f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom2();
        }
        else if (money >= 25 && fenceLVLCount == 5f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesRight2();
        }
        else if (money >= 25 && fenceLVLCount == 6f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop3();
        }
        else if (money >= 25 && fenceLVLCount == 7f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom3();
        }
        else if (money >= 25 && fenceLVLCount == 8f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesRight3();
        }
        else if (money >= 25 && fenceLVLCount == 9f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop4();
        }
        else if (money >= 25 && fenceLVLCount == 10f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom4();
        }
        else if (money >= 25 && fenceLVLCount == 11f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop5();
        }
        else if (money >= 25 && fenceLVLCount == 12f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom5();
        }
        else if (money >= 25 && fenceLVLCount == 13f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop6();
        }
        else if (money >= 25 && fenceLVLCount == 14f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom6();
        }
        else if (money >= 25 && fenceLVLCount == 15f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop7();
        }
        else if (money >= 25 && fenceLVLCount == 16f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom7();
        }
        else if (money >= 25 && fenceLVLCount == 17f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop8();
        }
        else if (money >= 25 && fenceLVLCount == 18f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom8();
        }
        else if (money >= 25 && fenceLVLCount == 19f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop9();
        }
        else if (money >= 25 && fenceLVLCount == 20f)
        {
            money -= 25;
            fenceLVLCount++;
            gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom9();
        }


    } 

    public void UpdateAmountNeededForPatches()
    {
        if (patchButtonInt == 0)
        {
            amountNeededFP = 25;
        }
        else if (patchButtonInt == 1)
        {
            amountNeededFP = 50;
        }
        else if (patchButtonInt == 2)
        {
            amountNeededFP = 100;
        }
        else if (patchButtonInt == 3)
        {
            amountNeededFP = 150;
        }
        else if (patchButtonInt == 4)
        {
            amountNeededFP = 200;
        }
        else if (patchButtonInt == 5)
        {
            amountNeededFP = 300;
        }
        else if (patchButtonInt == 6)
        {
            amountNeededFP = 500;
        }
        else if (patchButtonInt == 7)
        {
            amountNeededFP = 750;
        }
        else if (patchButtonInt == 8)
        {
            amountNeededFP = 1000;
        }
        else if (patchButtonInt == 9)
        {
            amountNeededFP = 1300;
        }
        else if (patchButtonInt == 10)
        {
            amountNeededFP = 1800;
        }
        else if (patchButtonInt == 11)
        {
            amountNeededFP = 2500;
        }
        else if (patchButtonInt == 12)
        {
            amountNeededFP = 3500;
        }
        else if (patchButtonInt == 13)
        {
            amountNeededFP = 4800;
        }
        else if (patchButtonInt == 14)
        {
            amountNeededFP = 6000;
        }
        else if (patchButtonInt == 15)
        {
            amountNeededFP = 8000;
        }
        else if (patchButtonInt == 16)
        {
            amountNeededFP = 10000;
        }
        else if (patchButtonInt == 17)
        {
            amountNeededFP = 15000;
        }
        else if (patchButtonInt == 18)
        {
            amountNeededFP = 20000;
        }
    }

    public void RefillPlayerHealth()
    {
        if(money >= 15 && player.GetComponent<PlayerStats>().playerHealth <= 10f)
        {
            money -= 15;
            player.GetComponent<PlayerStats>().playerHealth = 10f;
            refillHealthButton.enabled = false;
        }
        else
        {
            refillHealthButton.enabled = false;
        }
        
    }

    public void SaveButtonPressed()
    {
        Debug.Log("SaveGame");
        SaveSystem.SaveData1(this);
        SaveSystem.SaveData2(player.GetComponent<PlayerStats>());
        SaveSystem.SaveData3(patchSpawner.GetComponent<SpawnPatchScript>());
        //SaveSystem.SaveData4(plantPatcher.GetComponent<PlantingPatchScript>());
        //SaveSystem.SaveData2(GameData2);
    }

    public void LoadButtonPressed()
    {
        GameData1 data1 = SaveSystem.LoadData1();

        patchButtonInt = data1.currentPatches;
        money = data1.currentMoney;
        fenceLVLCount = data1.currentFences;
        levelCount = data1.currentLevel;

        Vector3 position;
        position.x = data1.playersPostition[0];
        position.y = data1.playersPostition[1];
        position.z = data1.playersPostition[2];
        player.transform.position = position;

        Vector3 PPosition;
        PPosition.x = data1.playersParentPostition[0];
        PPosition.y = data1.playersParentPostition[1];
        PPosition.z = data1.playersParentPostition[2];
        playerParent.transform.position = PPosition;

        GameData2 data2 = SaveSystem.LoadData2();
        player.GetComponent<PlayerStats>().playerHealth = data2.playerHealth;

        GameData3 data3 = SaveSystem.LoadData3();
        patchSpawner.GetComponent<SpawnPatchScript>().farmCount = data3.currentPatches;
        patchSpawner.GetComponent<SpawnPatchScript>().ResetLevel();
        //patchSpawner.GetComponent<SpawnPatchScript>().patchArray = data3.patches;
        //ms.GetComponent<EnemySpawner>().monsterPrefab.transform.position = new Vector3(UnityEngine.Random.Range(0f, 38f), UnityEngine.Random.Range(-32f, 30f), -0.1f);

        // GameData4 data4 = SaveSystem.LoadData4();
        // plantPatcher.GetComponent<PlantingPatchScript>().isNotPlanted = data4.currentPatchesCondition;
        

        mainMenuCanvas.SetActive(false);
        mainMenuTrue = false;
        playerHUD.SetActive(true);
        Time.timeScale = 1;


    }

    

    public void ToMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        mainMenuTrue = true;
        winCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        playerHUD.SetActive(false);
        Time.timeScale = 0;
    }

    public void ONewGame()
    {
        mainMenuCanvas.SetActive(false);
        newGamecanvas.SetActive(false);
        mainMenuTrue = false;
        playerHUD.SetActive(true);
        Time.timeScale = 1;
        patchSpawner.GetComponent<SpawnPatchScript>().ResetLevel();
        money = 0;
        moneyWS = 0;
        player.GetComponent<PlayerStats>().playerHealth = 10f;
        patchSpawner.GetComponent<SpawnPatchScript>().farmCount = 3;
        fenceLVLCount = 0f;
        ms.GetComponent<EnemySpawner>().monsterPrefab.transform.position = new Vector3(UnityEngine.Random.Range(0f, 38f), UnityEngine.Random.Range(-32f, 30f), -0.1f);
        Time.timeScale = 1;
        levelCount = 0;
    }

    public void NewGame()
    {
        mainMenuCanvas.SetActive(false);
        newGamecanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void OptionsButtonPressed()
    {
        mainMenuCanvas.SetActive(false);
        optionsCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void AudioButtonPressed()
    {
        mainMenuCanvas.SetActive(false);
        audioCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void CreditsButtonPressed()
    {
        mainMenuCanvas.SetActive(false);
        creditsCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void BackButtonPressed()
    {
        optionsCanvas.SetActive(true);
        creditsCanvas.SetActive(false);
        audioCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void BackToMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        optionsCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
