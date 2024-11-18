using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFlower : MonoBehaviour
{
    public bool IsOnTrigger = false;
    GameObject flow;
    public GameObject data;
    public Dictionary<string, int> score = new Dictionary<string, int>(){
        {"tutsan", 0},
        {"blooming sally", 0},
        {"mint", 0},
        {"chamomile", 0},
        {"strawberry", 0},
        {"primrose", 0}
    };

    void Start(){
        if(data.GetComponent<LoadData>().scoreLoaded.ContainsKey("tutsan")){
            Debug.Log("has key");
            score = data.GetComponent<LoadData>().scoreLoaded;
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        IsOnTrigger = true;
        flow = other.gameObject;
    }
    void OnTriggerExit2D(Collider2D other){
        IsOnTrigger = false;
    }

    void Update(){
        if (IsOnTrigger && Input.GetKeyDown(KeyCode.Space)){
            if(score.ContainsKey(flow.tag)){
                score[flow.tag] += 1;
                Destroy(flow);
                GetComponent<CreateFlowers>().count -= 1;
            }
        }
    }
}
