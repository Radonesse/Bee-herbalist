using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class LoadData : MonoBehaviour
{
    private bool BoolHasDataToLoad = false;
    public Dictionary<string, int> scoreLoaded = new Dictionary<string, int>();

    private void Awake(){
        HasDataToLoad();
        Load();
    }

    private void HasDataToLoad(){
        if(File.Exists(Application.persistentDataPath + "/SaveDataBee.dat")){
            Debug.Log("Has key");
            BoolHasDataToLoad = true;
        }else{
            Debug.Log("Has not key");
        }
    }

    private void Load(){
        if(BoolHasDataToLoad){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream FileData = File.Open(Application.persistentDataPath + "/SaveDataBee.dat", FileMode.Open);
            DataSave LastData = (DataSave)bf.Deserialize(FileData);
            FileData.Close();
            scoreLoaded = LastData.scoreSaved;
        }
    }
}
