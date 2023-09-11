using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlow : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other) {
        if(other.transform.tag == "Player"){
            other.attachedRigidbody.AddForce(other.transform.right * -1  * 15f);
        }
    }
}
