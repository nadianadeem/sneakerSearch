using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public static class saveSystem
{
    public static void SavePlayer(playerController pC, upgradeMaster crM, upgradeMaster caM, upgradeMaster fM, sneakerInventory sI, upgradeMaster aCM){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        playerData data = new playerData(pC, crM, caM, fM, sI, aCM);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static playerData LoadPlayer(){
        string path = Application.persistentDataPath + "/player.fun";
        try{
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            
            playerData data = formatter.Deserialize(stream) as playerData;
            stream.Close();

            return data;
        }
        catch{
            return null;
        }
    }
}
