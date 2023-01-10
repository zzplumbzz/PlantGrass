using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    // public void LoadButtonPressed()
    // {
    //     GameData1 data1 = SaveSystem.LoadData1();

    //     patchButtonInt = data1.currentPatches;
    //     money = data1.currentMoney;
    //     fenceLVLCount = data1.currentFences;

    //     Vector3 position;
    //     position.x = data1.playersPostition[0];
    //     position.y = data1.playersPostition[1];
    //     position.z = data1.playersPostition[2];
    //     player.transform.position = position;

    //     Vector3 PPosition;
    //     PPosition.x = data1.playersParentPostition[0];
    //     PPosition.y = data1.playersParentPostition[1];
    //     PPosition.z = data1.playersParentPostition[2];
    //     playerParent.transform.position = PPosition;

    //     GameData2 data2 = SaveSystem.LoadData2();
    //     player.GetComponent<PlayerStats>().playerHealth = data2.playerHealth;

    //     GameData3 data3 = SaveSystem.LoadData3();
    //     patchSpawner.GetComponent<SpawnPatchScript>().farmCount = data3.currentPatches;
    //     //ms.GetComponent<EnemySpawner>().monsterPrefab.transform.position = new Vector3(UnityEngine.Random.Range(0f, 38f), UnityEngine.Random.Range(-32f, 30f), -0.1f);

    //     // GameData4 data4 = SaveSystem.LoadData4();
    //     // plantPatcher.GetComponent<PlantingPatchScript>().isNotPlanted = data4.currentPatchesCondition;


       
    //     SceneManager.LoadScene("GameScene");
    // }
    

    // public void PlayGame()
    // {
    //     SceneManager.LoadScene("GameScene");
    // }

    // public void QuitGame()
    // {
    //     Application.Quit();
    // }
}
