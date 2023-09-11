using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpUp : MonoBehaviour
{
    [SerializeField]
    float ImpulseF = 25.0f;
    [SerializeField]
    float latesec = 1.0f;
    public Animator anim;
    private Rigidbody2D target;
    public float Impulse{get => ImpulseF;set => ImpulseF = value;}
    public Action CheatEffect = null;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player"){
            target = other.attachedRigidbody;
            Invoke("JumpUp", latesec);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.transform.tag == "Player"){
            target = null;
        }   
    }
    private void JumpUp(){
        if(anim) anim.SetTrigger("JumpUp");
        if(target){
            target.velocity = Vector2.zero;
            target.AddForce(target.transform.up * ImpulseF, ForceMode2D.Impulse);
            MoveController move = target.GetComponent<MoveController>();
            if(move){
                move.inAir();
            }
            if(CheatEffect != null)
                CheatEffect.Invoke();
        }
    }
}
