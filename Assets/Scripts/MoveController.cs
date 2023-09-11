using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    bool isAir = false;
    bool inTopViewTile = false;
    public Animator anim;
    public Rigidbody2D rigid;
    public float speed = 1.0f;
    public float jump = 1.0f;
    public float resistance = 0.0f;
    
    private void Update() {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed*(1f - resistance);
        float y = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.Translate(x,inTopViewTile ? y : 0, 0);
        if(Input.GetButtonDown("Jump")){
            if(!isAir) {
                rigid.AddForce(transform.up*jump);
                isAir = true;
            }
            if(inTopViewTile){
                rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
                rigid.AddForce(transform.up * jump);
                rigid.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.tag == "Level"){
            OnGround();
        }
    }
    public void OnGround(){
        isAir = false;
    }
    public void inAir(){
        isAir = true;
    }
    public void setResistence(float r){
        resistance = Mathf.Clamp(r, 0.0f, 1.0f);
    }
    public void canGoUp(){
        rigid.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        rigid.velocity = Vector2.zero;
        inTopViewTile = true;
    }
    public void cantGoUp(){
        rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
        inTopViewTile = false;
    }
}
