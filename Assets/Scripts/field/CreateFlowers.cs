using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateFlowers : MonoBehaviour
{
    public int time = 50, curTime = 0;
    public int count = 0;
    public GameObject[] flowers;

    void Update(){
        curTime += 1;
        if(curTime >= time && count < 20){
            Instantiate(flowers[UnityEngine.Random.Range(0, flowers.Length)], new Vector2(UnityEngine.Random.Range(-7.82f, 7.82f), UnityEngine.Random.Range(-4.12f, 4.12f)), Quaternion.Euler(0, 0, 0));
            count += 1;
            curTime = 0;
        }
    }
}
