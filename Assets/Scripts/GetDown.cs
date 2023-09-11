using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDown : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rid;
    [SerializeField]
    Collider2D col;
    private void OnTriggerEnter2D(Collider2D other) {
        if(!rid.simulated && other.tag == "Player"){
            rid.simulated = true;
            col.isTrigger = false;
        }

    }
}
