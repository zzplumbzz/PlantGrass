using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveData1(GameManagerScript gms)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path1 = Application.persistentDataPath + "/data1.SaveForData1";
        FileStream stream1 = new FileStream(path1,FileMode.Create);

        GameData1 data1 = new GameData1(gms);

        formatter.Serialize(stream1, data1);
        stream1.Close();
    }

    public static void SaveData2(PlayerStats ps)
    {
        //Debug.Log(data2);
        BinaryFormatter formatter = new BinaryFormatter();
        string path2 = Application.persistentDataPath + "/data2.SaveForData2";
        FileStream stream2 = new FileStream(path2, FileMode.Create);
        
        GameData2 data2 = new GameData2(ps);

        formatter.Serialize(stream2, data2);
        stream2.Close();
    }

    public static void SaveData3(SpawnPatchScript sps)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path3 = Application.persistentDataPath + "/data3.SaveForData3";
        FileStream stream3 = new FileStream(path3, FileMode.Create);

        GameData3 data3 = new GameData3(sps);

        formatter.Serialize(stream3, data3);
        stream3.Close();
    }

    // public static void SaveData4(PlantingPatchScript pps)
    // {
    //     BinaryFormatter formatter = new BinaryFormatter();
    //     string path4 = Application.persistentDataPath + "/data4.SaveForData4";
    //     FileStream stream4 = new FileStream(path4, FileMode.Create);

    //     GameData4 data4 = new GameData4(pps);

    //     formatter.Serialize(stream4, data4);
    //     stream4.Close();
    // }

    public static GameData1 LoadData1()
    {
        string path1 = Application.persistentDataPath + "/data1.SaveForData1";
        if(File.Exists(path1))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream1 = new FileStream(path1, FileMode.Open);

            GameData1 data1 = formatter.Deserialize(stream1) as GameData1;
            stream1.Close();

            return data1;
        }
        else
        {
            Debug.LogError("Save File NotFound In " + path1);
            return null;
        }
    }

    public static GameData2 LoadData2()
    {
        string path2 = Application.persistentDataPath + "/data2.SaveForData2";
        if (File.Exists(path2))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream2 = new FileStream(path2, FileMode.Open);

            GameData2 data2 = formatter.Deserialize(stream2) as GameData2;
            stream2.Close();

            return data2;
        }
        else
        {
            Debug.LogError("Save File NotFound In " + path2);
            return null;
        }
    }

    public static GameData3 LoadData3()
    {
        string path3 = Application.persistentDataPath + "/data3.SaveForData3";
        if (File.Exists(path3))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream3 = new FileStream(path3, FileMode.Open);

            GameData3 data3 = formatter.Deserialize(stream3) as GameData3;
            stream3.Close();

            return data3;
        }
        else
        {
            Debug.LogError("Save File NotFound In " + path3);
            return null;
        }
    }

    // public static GameData4 LoadData4()
    // {
    //     string path4 = Application.persistentDataPath + "/data4.SaveForData4";
    //     if (File.Exists(path4))
    //     {
    //         BinaryFormatter formatter = new BinaryFormatter();
    //         FileStream stream4 = new FileStream(path4, FileMode.Open);

    //         GameData4 data4 = formatter.Deserialize(stream4) as GameData4;
    //         stream4.Close();

    //         return data4;
    //     }
    //     else
    //     {
    //         Debug.LogError("Save File NotFound In " + path4);
    //         return null;
    //     }
    // }
}
