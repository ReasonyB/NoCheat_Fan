using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        MoveController mv = other.GetComponent<MoveController>();
        if(mv != null) mv.canGoUp();
    }
    private void OnTriggerExit2D(Collider2D other) {
        MoveController mv = other.GetComponent<MoveController>();
        if(mv != null) mv.cantGoUp();
    }
}
