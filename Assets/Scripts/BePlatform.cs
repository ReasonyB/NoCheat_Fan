using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BePlatform : MonoBehaviour
{
    public BoxCollider2D coll;
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
           coll.isTrigger = false; 
        }
    }
}
