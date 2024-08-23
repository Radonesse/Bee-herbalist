using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jar : MonoBehaviour
{
    int score;
    public GameObject data;

    void Start(){
        score = data.GetComponent<LoadData>().scoreLoaded[name];
        if (score > 0){
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = score.ToString();

        }
    }
}
