using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FlyToTarget))]
public class WhoIsFirst : MonoBehaviour
{
    public Action<GameObject> thisisFirst;
    private void Start() {
        thisisFirst = DebugMessage;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            thisisFirst(gameObject);
            Destroy(this);
        }
    }
    
    private void DebugMessage(GameObject obj){
        Debug.Log($"{obj.name}의 WhoIsFirst가 작동 중");
    }
}
