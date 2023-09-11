using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Enter");
    }
    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Exit");
    }
}
