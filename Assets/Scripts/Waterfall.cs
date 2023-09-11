using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterfall : MonoBehaviour, IResistive{
    int direction = 1;
    public float resistance = 0.9f;
    [SerializeField]
    float waterpressure = 25.0f;

    public float Resistance { get => resistance; set => resistance = value; }
    public void setDriection(int d){
        direction = d;
    }
    public void setWaterPressure(float p){
        waterpressure = p;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        other.GetComponent<MoveController>()?.setResistence(resistance);
    }

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player"){
            other.attachedRigidbody.AddForce(Vector2.down * direction * waterpressure);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        other.GetComponent<MoveController>()?.setResistence(0.0f);
    }
}
