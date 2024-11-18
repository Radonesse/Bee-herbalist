using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Reset : MonoBehaviour
{
    public GameObject score;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            if(File.Exists(Application.persistentDataPath + "/SaveDataBee.dat")){
                score.GetComponent<GetFlower>().score = new Dictionary<string, int>(){
                    {"tutsan", 0},
                    {"blooming sally", 0},
                    {"mint", 0},
                    {"chamomile", 0},
                    {"strawberry", 0},
                    {"primrose", 0}
                };
                File.Delete(Application.persistentDataPath + "/SaveDataBee.dat");
                Debug.Log("Reset Bee");
            }
            else{
                Debug.Log("no data to reset");
            }
        }
    }
}
