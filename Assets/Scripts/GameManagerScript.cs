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
    public GameObject shop1Canvas;
    public GameObject shop2Canvas;
    public GameObject storyCanvas;
    public GameObject BeatGameCanvas;
    public GameObject looseCanvas;
    public GameObject howToPlayScreenMM;
    public GameObject howToPlayScreenPS;
    public GameObject starterFarmHouse;
    public bool SHSet;
    public SpriteRenderer SHS;
    public Collider2D SHSBC;
    public GameObject doubleMoneyFarmHouse;
    public bool purchasedDMHouse;
    public BoxCollider2D DMHBC;
    public EdgeCollider2D DMHEC;
    public bool DMHouseSet;
    public SpriteRenderer DMHS;
    public GameObject fasterPlayerFarmHouse;
    public bool purchasedFPHouse;
    public bool FPHouseSet;
    public SpriteRenderer FPHS;
    public BoxCollider2D FPBC;
    public GameObject strongerFenceFarmHouse;
    public bool purchasedSFHouse;
    public bool SFHouseSet;
    public SpriteRenderer SFHS;
    public BoxCollider2D SFBC;
    public GameObject tripleMoneyFarmHouse;
    public bool purchasedTMHouse;
    public bool TMHouseSet;
    public SpriteRenderer TMHS;
    public BoxCollider2D TMHBC;
    public EdgeCollider2D TMHEC;
    public TMP_Text SHAmount;
    public TMP_Text DMHAmount;
    public TMP_Text FPHAmount;
    public TMP_Text SFHAmount;
    public TMP_Text TMHAmount;
    public bool mainMenuTrue;
    public bool pauseMenuTrue;
    public Button purchasePatchButton;
    public Button purchaseFenceButton;
    public Button refillHealthButton;
    public Button backButtonMM;
    public TMP_Text backButtonMMTXT;
    public Image backButtonMMIM;
    public Button backButtonPM;
    public TMP_Text backButtonPMTXT;
    public Image backButtonPMIM;
    public int plusOneCounted;
    public TMP_Text patchCount;
    public TMP_Text moneyCount;
    public TMP_Text moneyCountWS;
    public TMP_Text moneyCountSS;
    public int money;
    public int moneyWS;
    public int moneySS;
    //public TMP_Text HealthWS;
    public TMP_Text currentLevelWS;
    private FenceSpawningScript fss;
    private GameObject ess;
    private PlayerStats ps;
    private GameObject am;
    public GameObject patchClone;
    public GameObject enemyClone;
    public bool winTrue;
    private GameObject sps;
    public GameObject player;
    //public GameObject playerParent;
    public GameObject patchSpawner;
    public GameObject plantPatcher;
    public GameObject ms;
    public float fenceLVLCount;
    public int patchButtonInt;
    public int amountNeededFP;
   // public int amountNeededFF;
    public TMP_Text amountNeededPTXT;
    //public TMP_Text amountNeededFTXT;
    public TMP_Text amountNeededHTXT;
    public GameObject amountNeededTXTBG;
    //public TMP_Text playerHealthTXT;
    //public float playersHealth;
    public int levelCount;
    public AudioSource winSound;
    public AudioSource deathSound;
    public AudioSource takesDamageSound;
    public AudioSource MM;
    //public AudioSource GP;
    //public AudioSource SM;
    private GameObject audioManager;

    public Image BGChest;
    public TMP_Text ChestText;
    private GameObject scs;

    public Image SGBGI;
    public TMP_Text SG;
    public bool gameSaved;
    
    private bool beatGame;
    public int beatGameCounter = 0;
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
        shop1Canvas.SetActive(false);
        storyCanvas.SetActive(false);
        BeatGameCanvas.SetActive(false);
        looseCanvas.SetActive(false);
        shop2Canvas.SetActive(false);
        howToPlayScreenMM.SetActive(false);
        howToPlayScreenPS.SetActive(false);
        starterFarmHouse.SetActive(true);
        doubleMoneyFarmHouse.SetActive(false);
        tripleMoneyFarmHouse.SetActive(false);
        strongerFenceFarmHouse.SetActive(false);
        fasterPlayerFarmHouse.SetActive(false);
        
        plusOneCounted = 0;
        winTrue = false;
        pauseMenuTrue = false;
        sps = GameObject.Find("ChangingPatches");
        audioManager = GameObject.Find("AudioManager");
        scs = GameObject.Find("SecretChestClosed");
        //am = GameObject.Find("Slider");
        Time.timeScale = 1;
        patchButtonInt = 0;
        amountNeededFP = 20;
        //amountNeededFF = 25;
        player.transform.position = new Vector3(-9f, -0.15f, -0.1f);
        //playerParent.transform.position = new Vector3(-9f, -0.15f, -0.1f);
        SHAmount.SetText("Set.");
        ess = GameObject.Find("MonsterSpawner");
        //am.GetComponent<AudioManager>().ChangeVolume();
        MM.enabled = true;
        //MM.playOnAwake = false;
        //GP.enabled = false;
        //SM.enabled = false;
        
        audioManager.GetComponent<AudioManager>().Load();

        BGChest.enabled = false;
        ChestText.enabled = false;

        SG.enabled = false;
        SGBGI.enabled = false;

        backButtonPM.enabled = false;

        SHS.enabled = false;
        DMHS.enabled = false;
        SFHS.enabled = false;
        FPHS.enabled = false;
        TMHS.enabled = false;

        SHSBC.enabled = false;
        DMHBC.enabled = false;
        DMHEC.enabled = false;
        SFBC.enabled = false;
        FPBC.enabled = false;
        TMHBC.enabled = false;
        TMHEC.enabled = false;
    }

    private void FixedUpdate() 
    {
        amountNeededHTXT.SetText("You Need $15 to Replenish Your Health.");
        
        
    }

    private void Update() 
    {
        //Debug.Log(levelCount);
        //money = 1000000;

        if (gameSaved == true)
        {
            
            SG.enabled = true;
            SGBGI.enabled = true;
        }
        if (gameSaved == false)
        {
            SG.enabled = false;
            SGBGI.enabled = false;
        }
        

        if(mainMenuTrue == true)
        {
            winCanvas.SetActive(false);
            pauseCanvas.SetActive(false);
            playerHUD.SetActive(false);
            MM.enabled = true;
            Time.timeScale = 0;
        }

        if (purchasedDMHouse == false)
        {
            DMHAmount.SetText("You Need " + "$20,000 To Purchace.");
        }
        if (purchasedFPHouse == false)
        {
            FPHAmount.SetText("You Need " + "$15,000 To Purchace.");
        }
        if (purchasedSFHouse == false)
        {
            SFHAmount.SetText("You Need " + "$15,000 To Purchace.");
        }
        if (purchasedTMHouse == false)
        {
            TMHAmount.SetText("You Need " + "$30,000 To Purchace.");
        }

        if(SHSet == true )
        {
            

            SHAmount.SetText("Set.");

            SHS.enabled = true;

            SHSBC.enabled = true;
            DMHBC.enabled = false;
            DMHEC.enabled = false;
            SFBC.enabled = false;
            FPBC.enabled = false;
            TMHBC.enabled = false;
            TMHEC.enabled = false;

        }
        else if(SHSet == false)
        {
            SHAmount.SetText("Purchased.");
        }
        if (purchasedDMHouse == true && DMHouseSet == false)
        {
            
            DMHAmount.SetText("Purchaced.");
            
            
        }
        else if(purchasedDMHouse == true && DMHouseSet == true)
        {
            
            DMHAmount.SetText("Set.");

            DMHS.enabled = true;

            SHSBC.enabled = false;
            DMHBC.enabled = true;
            DMHEC.enabled = true;
            SFBC.enabled = false;
            FPBC.enabled = false;
            TMHBC.enabled = false;
            TMHEC.enabled = false;
            
        }

        if (purchasedFPHouse == true && FPHouseSet == false)
        {
            FPHAmount.SetText("Purchaced.");
            
            
        }
        else if(purchasedFPHouse == true && FPHouseSet == true)
        {
            
            FPHAmount.SetText("Set.");

            FPHS.enabled = true;

            SHSBC.enabled = false;
            DMHBC.enabled = false;
            DMHEC.enabled = false;
            SFBC.enabled = false;
            FPBC.enabled = true;
            TMHBC.enabled = false;
            TMHEC.enabled = false;
            
        }

        if (purchasedSFHouse == true && SFHouseSet == false)
        {
            SFHAmount.SetText("Purchaced.");
            
        }
        else if(purchasedSFHouse == true && SFHouseSet == true)
        {
            
            SFHAmount.SetText("Set.");

            SFHS.enabled = true;

            SHSBC.enabled = false;
            DMHBC.enabled = false;
            DMHEC.enabled = false;
            SFBC.enabled = true;
            FPBC.enabled = false;
            TMHBC.enabled = false;
            TMHEC.enabled = false;
        }

        if (purchasedTMHouse == true && TMHouseSet == false)
        {
            TMHAmount.SetText("Purchaced.");
            
        }
        else if (purchasedTMHouse == true && TMHouseSet == true)
        {
           
            TMHAmount.SetText("Set.");

            TMHS.enabled = true;

            SHSBC.enabled = false;
            DMHBC.enabled = false;
            DMHEC.enabled = false;
            SFBC.enabled = false;
            FPBC.enabled = false;
            TMHBC.enabled = true;
            TMHEC.enabled = true;
            
        }

        // if(fenceLVLCount <= 0f)
        // {
        //     fenceLVLCount = 0f;
        // }
        
        //playersHealth = GetComponent<PlayerStats>().playerHealth;
        patchCount.SetText(plusOneCounted.ToString());
        moneyCount.SetText(money.ToString());
        moneyCountWS.SetText(money.ToString());
        moneyCountSS.SetText(money.ToString());
        //HealthWS.SetText(player.GetComponent<PlayerStats>().playerHealth.ToString());
        amountNeededPTXT.SetText("You Need " + "$" + amountNeededFP.ToString() + " To purchase more Patches.");
        currentLevelWS.SetText(levelCount.ToString());
        // amountNeededFTXT.SetText("You Need " + "$" + amountNeededFF.ToString() + " To purchase more Fences.");

        //playerHealthTXT.SetText(player.GetComponent<PlayerStats>().playerHealth.ToString());
        UpdateAmountNeededForPatches();

        

        if (patchButtonInt >= 19)
        {
            purchasePatchButton.enabled = false;
        }

        // if(fenceLVLCount <= 20f)
        // {
        //     purchaseFenceButton.enabled = true;
        // }
        // else if (fenceLVLCount >= 21f)
        // {

        //     purchaseFenceButton.enabled = false;
        // }

        if (Input.GetKeyDown(KeyCode.P))//&& winCanvas.active == false
        {
            pauseCanvas.SetActive(true);
            playerHUD.SetActive(false);
            pauseMenuTrue = true;
            Time.timeScale = 0;
        }

        if(winTrue == true)
        {
            pauseCanvas.SetActive(false);
            pauseMenuTrue = false;
        }

        if(plusOneCounted <= 0)
        {
            plusOneCounted = 0;
        }

        if (plusOneCounted >= sps.GetComponent<SpawnPatchScript>().patchArray.Length && winTrue == false)
        {
            winTrue = true;
            winCanvas.SetActive(true);
            plusOneCounted = 0;
            Time.timeScale = 0;
            levelCount += 1;
            winSound.Play();
            //GP.enabled = false;
            //SM.enabled = true;

            if (DMHouseSet == false && TMHouseSet == false)
            {
                money += sps.GetComponent<SpawnPatchScript>().patchArray.Length;
            }

            if (DMHouseSet == true)
            {
                money += sps.GetComponent<SpawnPatchScript>().patchArray.Length * 2;
            }

            if (TMHouseSet == true)
            {
                money += sps.GetComponent<SpawnPatchScript>().patchArray.Length * 3;
            }
            
        }

        if(player.GetComponent<PlayerStats>().playerHealth <= 0)
        {
            looseCanvas.SetActive(true);
           // GP.enabled = false;
            //MM.enabled = true;
        }


        if (player.GetComponent<PlayerStats>().playerHealth <= 10f)
        {
            refillHealthButton.enabled = true;
        }

        if (player.GetComponent<PlayerStats>().playerHealth >= 10f)
        {
            refillHealthButton.enabled = false;

        }

      
        
        if(beatGameCounter >= 4)
        {
            beatGame = true;
        }

        if(beatGame == true && beatGameCounter >= 4)
        {
            beatGameCounter = 0;
            BeatGameCanvas.SetActive(true);
            Time.timeScale = 0;
            
        }

        if(mainMenuTrue == true)
        {
            backButtonMM.enabled = true;
            backButtonMMIM.enabled = true;
            backButtonMMTXT.enabled = true;

            backButtonPM.enabled = false;
            backButtonPMIM.enabled = false;
            backButtonPMTXT.enabled = false;

        }
        

        if(pauseMenuTrue == true)
        {
            backButtonPM.enabled = true;
            backButtonPMIM.enabled = true;
            backButtonPMTXT.enabled = true;

            backButtonMM.enabled = false;
            backButtonMMIM.enabled = false;
            backButtonMMTXT.enabled = false;
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
        gameSaved = false;
        pauseMenuTrue = false;
        Time.timeScale = 1;
        
    }

    // public void PurchaseButtonPressed()
    // {
    //     if (money >= 25 && fenceLVLCount == 0f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop1();

    //     }
    //     else if (money >= 25 && fenceLVLCount == 1f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom1();
            
    //     }
    //     else if (money >= 25 && fenceLVLCount == 2f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesRight1();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 3f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop2();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 4f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom2();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 5f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesRight2();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 6f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop3();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 7f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom3();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 8f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesRight3();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 9f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop4();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 10f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom4();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 11f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop5();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 12f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom5();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 13f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop6();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 14f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom6();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 15f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop7();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 16f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom7();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 17f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop8();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 18f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom8();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 19f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesTop9();
    //     }
    //     else if (money >= 25 && fenceLVLCount == 20f)
    //     {
    //         money -= 25;
    //         fenceLVLCount++;
    //         gameObject.GetComponent<FenceSpawningScript>().SpawnFencesBottom9();
    //     }


    // } 

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
            amountNeededFP = 250;
        }
        else if (patchButtonInt == 4)
        {
            amountNeededFP = 750;
        }
        else if (patchButtonInt == 5)
        {
            amountNeededFP = 1500;
        }
        else if (patchButtonInt == 6)
        {
            amountNeededFP = 2000;
        }
        else if (patchButtonInt == 7)
        {
            amountNeededFP = 3000;
        }
        else if (patchButtonInt == 8)
        {
            amountNeededFP = 4500;
        }
        else if (patchButtonInt == 9)
        {
            amountNeededFP = 6500;
        }
        else if (patchButtonInt == 10)
        {
            amountNeededFP = 8000;
        }
        else if (patchButtonInt == 11)
        {
            amountNeededFP = 10500;
        }
        else if (patchButtonInt == 12)
        {
            amountNeededFP = 15000;
        }
        else if (patchButtonInt == 13)
        {
            amountNeededFP = 20500;
        }
        else if (patchButtonInt == 14)
        {
            amountNeededFP = 25000;
        }
        else if (patchButtonInt == 15)
        {
            amountNeededFP = 30000;
        }
        else if (patchButtonInt == 16)
        {
            amountNeededFP = 40000;
        }
        else if (patchButtonInt == 17)
        {
            amountNeededFP = 50000;
        }
        else if (patchButtonInt == 18)
        {
            amountNeededFP = 60000;
        }
    }

    public void RefillPlayerHealth()
    {
        

        if(money >= 15 && player.GetComponent<PlayerStats>().playerHealth <= 10f)
        {
            money -= 15;
            player.GetComponent<PlayerStats>().playerHealth = 10f;
            
        }
        
      
        
        
    }

    public void SaveButtonPressed()
    {
        gameSaved = true;
        Debug.Log("SaveGame");
        SaveSystem.SaveData1(this);
        SaveSystem.SaveData2(player.GetComponent<PlayerStats>());
        SaveSystem.SaveData3(patchSpawner.GetComponent<SpawnPatchScript>());
        SaveSystem.SaveData4(scs.GetComponent<SecretChestScript>());
        //SaveSystem.SaveData2(GameData2);

        
    }

    public void LoadButtonPressed()
    {
        GameData1 data1 = SaveSystem.LoadData1();

        patchButtonInt = data1.currentPatches;
        money = data1.currentMoney;
        fenceLVLCount = data1.currentFences;
        levelCount = data1.currentLevel;
        SHSet = data1.SHSet;
        DMHouseSet = data1.DMHSet;
        purchasedDMHouse = data1.DMHPurchased;
        TMHouseSet = data1.TMHSet;
        purchasedTMHouse = data1.TMHPurchased;
        FPHouseSet = data1.FPHSet;
        purchasedFPHouse = data1.FPHPurchased;
        SFHouseSet = data1.SFHSet;
        purchasedSFHouse = data1.SFHPurchased;
        
        

        if(levelCount >= 5)
        {
            ess.GetComponent<EnemySpawner>().timerOn = true;
        }
        
        ms.GetComponent<EnemySpawner>().monsterPrefab.transform.position
        = new Vector3(38f, -32f, -0.1f);

        Vector3 position;
        position.x = data1.playersPostition[0];
        position.y = data1.playersPostition[1];
        position.z = data1.playersPostition[2];
        player.transform.position = position;

        Vector3 PPosition;
        PPosition.x = data1.playersParentPostition[0];
        PPosition.y = data1.playersParentPostition[1];
        PPosition.z = data1.playersParentPostition[2];
        //playerParent.transform.position = PPosition;

        GameData2 data2 = SaveSystem.LoadData2();
        player.GetComponent<PlayerStats>().playerHealth = data2.playerHealth;

        GameData3 data3 = SaveSystem.LoadData3();
        patchSpawner.GetComponent<SpawnPatchScript>().farmCount = data3.currentPatches;
        patchSpawner.GetComponent<SpawnPatchScript>().ResetLevel();
        
        GameData4 data4 = SaveSystem.LoadData4();
        scs.GetComponent<SecretChestScript>().isOpen = data4.ChestOpen;

        mainMenuCanvas.SetActive(false);
        newGamecanvas.SetActive(false);
        mainMenuTrue = false;
        looseCanvas.SetActive(false);
        playerHUD.SetActive(true);
        //MM.enabled = false;
        //GP.enabled = true;
        Time.timeScale = 1;

        
    }

    public void StarterHouse()
    {
        if(SHSet == false)
        {
            SHSet = true;
            DMHouseSet = false;
            TMHouseSet = false;
            FPHouseSet = false;
            SFHouseSet = false;

            starterFarmHouse.SetActive(true);
            doubleMoneyFarmHouse.SetActive(false);
            tripleMoneyFarmHouse.SetActive(false);
            strongerFenceFarmHouse.SetActive(false);
            fasterPlayerFarmHouse.SetActive(false);

            SHS.enabled = true;
            DMHS.enabled = false;
            TMHS.enabled = false;
            FPHS.enabled = false;
            SFHS.enabled = false;

            SHSBC.enabled = true;
            
           
        }
     }

    public void PurchaseDoubleMoneyHouse()
    {
        if(money >= 20000 && purchasedDMHouse == false)
        {
            money -= 20000;

            purchasedDMHouse = true;

            beatGameCounter += 1;

            DMHouseSet = true;
            SHSet = false;
            TMHouseSet = false;
            FPHouseSet = false;
            SFHouseSet = false;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(true);
            tripleMoneyFarmHouse.SetActive(false);
            strongerFenceFarmHouse.SetActive(false);
            fasterPlayerFarmHouse.SetActive(false);

            SHS.enabled = false;
            DMHS.enabled = true;
            TMHS.enabled = false;
            FPHS.enabled = false;
            SFHS.enabled = false;

            DMHBC.enabled = true;
            DMHEC.enabled = true;
        }
        else if(purchasedDMHouse == true && DMHouseSet == false)
        {
            DMHouseSet = true;
            SHSet = false;
            TMHouseSet = false;
            FPHouseSet = false;
            SFHouseSet = false;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(true);
            tripleMoneyFarmHouse.SetActive(false);
            strongerFenceFarmHouse.SetActive(false);
            fasterPlayerFarmHouse.SetActive(false);

            SHS.enabled = false;
            DMHS.enabled = true;
            TMHS.enabled = false;
            FPHS.enabled = false;
            SFHS.enabled = false;

           

        }
        
        
    }

    public void PurchaseTripleMoneyHouse()
    {
        if(money >= 30000 && purchasedTMHouse == false)
        {
            money -= 30000;

            TMHouseSet = true;
            DMHouseSet = false;
            SHSet = false;
            FPHouseSet = false;
            SFHouseSet = false;

            purchasedTMHouse = true;

            beatGameCounter += 1;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(false);
            tripleMoneyFarmHouse.SetActive(true);
            strongerFenceFarmHouse.SetActive(false);
            fasterPlayerFarmHouse.SetActive(false);

            SHS.enabled = false;
            DMHS.enabled = false;
            TMHS.enabled = true;
            FPHS.enabled = false;
            SFHS.enabled = false;

            TMHBC.enabled = true;
            TMHEC.enabled = true;
        }
        else if(purchasedTMHouse == true && TMHouseSet == false)
        {
            TMHouseSet = true;
            DMHouseSet = false;
            SHSet = false;
            FPHouseSet = false;
            SFHouseSet = false;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(false);
            tripleMoneyFarmHouse.SetActive(true);
            strongerFenceFarmHouse.SetActive(false);
            fasterPlayerFarmHouse.SetActive(false);

            SHS.enabled = false;
            DMHS.enabled = false;
            TMHS.enabled = true;
            FPHS.enabled = false;
            SFHS.enabled = false;
        }
        
    }

    public void PurchaseFasterPlayerHouse()
    {
        if(money >= 15000 && purchasedFPHouse == false)
        {
            money -= 15000;

            purchasedFPHouse = true;

            beatGameCounter += 1;

            FPHouseSet = true;
            DMHouseSet = false;
            SHSet = false;
            TMHouseSet = false;
            SFHouseSet = false;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(false);
            tripleMoneyFarmHouse.SetActive(false);
            strongerFenceFarmHouse.SetActive(false);
            fasterPlayerFarmHouse.SetActive(true);

            SHS.enabled = false;
            DMHS.enabled = false;
            TMHS.enabled = false;
            FPHS.enabled = true;
            SFHS.enabled = false;

            FPBC.enabled = true;
        }
        else if(purchasedFPHouse == true && FPHouseSet == false)
        {
            FPHouseSet = true;
            DMHouseSet = false;
            SHSet = false;
            TMHouseSet = false;
            SFHouseSet = false;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(false);
            tripleMoneyFarmHouse.SetActive(false);
            strongerFenceFarmHouse.SetActive(false);
            fasterPlayerFarmHouse.SetActive(true);

            SHS.enabled = false;
            DMHS.enabled = false;
            TMHS.enabled = false;
            FPHS.enabled = true;
            SFHS.enabled = false;
        }
        
    }   

    public void PurcahseStrongerFenceHouse()
    {
        if(money >= 15000 && purchasedSFHouse == false)
        {
            money -= 15000;

            purchasedSFHouse = true;

            beatGameCounter += 1;

            DMHouseSet = false;
            SHSet = false;
            TMHouseSet = false;
            FPHouseSet = false;
            SFHouseSet = true;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(false);
            tripleMoneyFarmHouse.SetActive(false);
            strongerFenceFarmHouse.SetActive(true);
            fasterPlayerFarmHouse.SetActive(false);

            SHS.enabled = false;
            DMHS.enabled = false;
            TMHS.enabled = false;
            FPHS.enabled = false;
            SFHS.enabled = true;

            SFBC.enabled = true;
        }
        else if(purchasedSFHouse == true && SFHouseSet == false)
        {
            DMHouseSet = false;
            SHSet = false;
            TMHouseSet = false;
            FPHouseSet = false;
            SFHouseSet = true;

            starterFarmHouse.SetActive(false);
            doubleMoneyFarmHouse.SetActive(false);
            tripleMoneyFarmHouse.SetActive(false);
            strongerFenceFarmHouse.SetActive(true);
            fasterPlayerFarmHouse.SetActive(false);

            SHS.enabled = false;
            DMHS.enabled = false;
            TMHS.enabled = false;
            FPHS.enabled = false;
            SFHS.enabled = true;
        }
        
        
    } 

    public void ToMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        mainMenuTrue = true;
        winCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        playerHUD.SetActive(false);
        howToPlayScreenMM.SetActive(false);
        looseCanvas.SetActive(false);
        Time.timeScale = 0;
        //GP.enabled = false;
        MM.enabled = true;
    }

    public void ToPauseScreen()
    {
        howToPlayScreenPS.SetActive(false);
        audioCanvas.SetActive(false);
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void ONewGame()
    {
        mainMenuCanvas.SetActive(false);
        newGamecanvas.SetActive(false);
        mainMenuTrue = false;
        storyCanvas.SetActive(true);
        
    }

    public void PlayButtonPressed()
    {
        storyCanvas.SetActive(false);
        playerHUD.SetActive(true);
        Time.timeScale = 1;
        patchSpawner.GetComponent<SpawnPatchScript>().ResetLevel();
        money = 0;
        moneyWS = 0;
        moneySS = 0;
        player.GetComponent<PlayerStats>().playerHealth = 10f;
        patchSpawner.GetComponent<SpawnPatchScript>().farmCount = 3;
        fenceLVLCount = 0f;
        ms.GetComponent<EnemySpawner>().monsterPrefab.transform.position = new Vector3(UnityEngine.Random.Range(0f, 38f), UnityEngine.Random.Range(-32f, 30f), -0.1f);
        Time.timeScale = 1;
        levelCount = 0;
        //MM.enabled = false;
        //GP.enabled = true;
        beatGameCounter = 0;
        StarterHouse();
        purchasedDMHouse = false;
        purchasedFPHouse = false;
        purchasedSFHouse = false;
        purchasedTMHouse = false;

    }

    public void NewGame()
    {
        mainMenuCanvas.SetActive(false);
        newGamecanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void ContinueFromBeatGame()
    {
        beatGame = false;
        BeatGameCanvas.SetActive(false);
    }

    public void OptionsButtonPressed()
    {
        mainMenuCanvas.SetActive(false);
        optionsCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void HowToPlayButtonMM()
    {
        mainMenuCanvas.SetActive(false);
        mainMenuTrue = false;
        winCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        playerHUD.SetActive(false);
        optionsCanvas.SetActive(false);
        audioCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        newGamecanvas.SetActive(false);
        shop1Canvas.SetActive(false);
        storyCanvas.SetActive(false);
        howToPlayScreenPS.SetActive(false);
        howToPlayScreenMM.SetActive(true);
    }

    public void HowToPlayButtonPS()
    {
        mainMenuCanvas.SetActive(false);
        mainMenuTrue = false;
        winCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        playerHUD.SetActive(false);
        optionsCanvas.SetActive(false);
        audioCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        newGamecanvas.SetActive(false);
        shop1Canvas.SetActive(false);
        storyCanvas.SetActive(false);
        howToPlayScreenPS.SetActive(true);
        howToPlayScreenMM.SetActive(false);
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

    public void ShopButtonPressed()
    {
        winCanvas.SetActive(false);
        shop1Canvas.SetActive(true);
    }

    public void OpenShop2()
    {
        shop1Canvas.SetActive(false);
        shop2Canvas.SetActive(true);
        
    }

    public void BackToWinScreen()
    {
        winCanvas.SetActive(true);
        shop1Canvas.SetActive(false);
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
