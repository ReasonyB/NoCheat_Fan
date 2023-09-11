using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyToTarget : MonoBehaviour
{
    [SerializeField]
    Transform[] targets;
    [SerializeField]
    float speed  = 1f;
    Vector3 from;
    Vector3 to;
    Vector3 origin;
    bool onRide = false;
    bool isLock = false;
    List<Vector3> points = new List<Vector3>();
    MoveController pmc = null;
    int cur = 0;

    private void Awake() {
        origin = transform.position;
    }
    private void Start() {
        to = origin;
        from = origin;
    }
    private void Update() {
        float step = Time.deltaTime * speed;
        if(Vector3.Distance(transform.position, to) == 0 ){
            if(onRide){
                to = NextTo();
            }
            else{
                to = origin;
                cur = 0;
            }
        }
        else{
            transform.position = Vector3.MoveTowards(transform.position, to, step);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            onRide = true;
            to = from != origin ? from : NextTo();
            pmc = other.GetComponent<MoveController>();
            if(!pmc){
                pmc.enabled = isLock;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
            onRide = false;
            from = to;
            to = origin;
        }
    }
    private Vector3 NextTo(){
        if(points.Count==0){SetPoints(targets);}
        int i = Mathf.Clamp(++cur,0,points.Count-1);
        cur = i;
        return points[i];

    }
    public void ManualOn(bool islock){
        onRide = true;
        isLock = islock;
    }
    public void SetPoints(Transform[] stations){
        points.Clear();
        points.Add(origin);
        foreach(var st in stations){
            points.Add(st.position);
        }
    }
}
