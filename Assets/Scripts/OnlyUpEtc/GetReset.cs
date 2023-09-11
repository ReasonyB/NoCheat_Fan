using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetReset : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rid;
    Vector3 origin;
    private void Awake() {
        origin = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Level"){
            rid.simulated = false;
            rid.Sleep();
            transform.position = origin;
        }
    }
}
