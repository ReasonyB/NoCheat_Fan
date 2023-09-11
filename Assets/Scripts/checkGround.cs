using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkGround : MonoBehaviour
{
    public MoveController control;
    private void OnTriggerStay2D(Collider2D other) {
        Debug.Log("plz play");
        if(control != null && other.transform.tag == "Level"){
            control.OnGround();
            Debug.Log("isOnGround");
        }
    }
}
