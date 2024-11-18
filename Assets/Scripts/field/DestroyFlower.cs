using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFlower : MonoBehaviour
{
    public GameObject _count;

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name != "ToHouseTrigger"){
            Destroy(other.gameObject);
            _count.GetComponent<CreateFlowers>().count -= 1;
        }
    }
}
