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
    public bool SHSet;
    public bool DMHPurchased;
    public bool DMHSet;
    public bool TMHSet;
    public bool TMHPurchased;
    public bool FPHSet;
    public bool FPHPurchased;
    public bool SFHSet;
    public bool SFHPurchased;

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

        SHSet = gms.SHSet;
        DMHSet = gms.DMHouseSet;
        TMHSet = gms.TMHouseSet;
        FPHSet = gms.FPHouseSet;
        SFHSet = gms.SFHouseSet;

        DMHPurchased = gms.purchasedDMHouse;
        TMHPurchased = gms.purchasedTMHouse;
        FPHPurchased = gms.purchasedFPHouse;
        SFHPurchased = gms.purchasedSFHouse;
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
    public bool ChestOpen;

    public GameData4(SecretChestScript scs)
    {
        ChestOpen = scs.isOpen;
    }
}
