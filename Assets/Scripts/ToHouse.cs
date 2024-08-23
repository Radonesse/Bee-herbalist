using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class ToHouse : MonoBehaviour
{
    public bool IsOnTrigger = false;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "ToHouseTrigger"){
            IsOnTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D other){
        IsOnTrigger = false;
    }

    void Update(){
        if (IsOnTrigger && Input.GetKeyDown(KeyCode.Return)){
            SaveData();
        }
    }

    void SaveData(){
        BinaryFormatter bf = new BinaryFormatter();
        FileStream FileData = File.Create(Application.persistentDataPath + "/SaveDataBee.dat");
        DataSave LastData = new DataSave();
        LastData.scoreSaved = GetComponent<GetFlower>().score;
        bf.Serialize(FileData, LastData);
        FileData.Close();
        SceneManager.LoadScene(1);
    }
}

[Serializable]
public class DataSave{
    public Dictionary<string, int> scoreSaved = new Dictionary<string, int>();
}
