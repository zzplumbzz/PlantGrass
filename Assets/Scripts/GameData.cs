using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData1
{
    public int currentPatches;
    public int currentMoney;
    public float currentFences;
    public int currentLevel;
    public float[] playersParentPostition;
    public float[] playersPostition;

    public GameData1(GameManagerScript gms)
    {
        currentPatches = gms.patchButtonInt;
        currentMoney = gms.money;
        currentFences = gms.fenceLVLCount;
        currentLevel = gms.levelCount;
        playersParentPostition = new float[3];
        playersParentPostition[0] = -9f;
        playersParentPostition[1] = -0.15f;
        playersParentPostition[2] = -0.1f;
        playersPostition = new float[3];
        playersPostition[0] = -9f;
        playersPostition[1] = -0.15f;
        playersPostition[2] = -0.1f;
    }
}

[System.Serializable]
public class GameData2
{
    public float playerHealth;

    public GameData2(PlayerStats ps)
    {
        playerHealth = ps.playerHealth;
    }
}

[System.Serializable]
public class GameData3
{
    public int currentPatches;
    //public float[] patches;
    public GameData3(SpawnPatchScript sps)
    {
        currentPatches = sps.farmCount;
        //patches = sps.patchArray;
    }
}

[System.Serializable]
public class GameData4
{
    public bool currentFences;

    public GameData4(FenceSpawningScript fss)
    {
        
    }
}
