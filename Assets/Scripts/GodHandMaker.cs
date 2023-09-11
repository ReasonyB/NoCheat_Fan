using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodHandMaker : MonoBehaviour
{
    [SerializeField]
    GameObject lefthand;
    [SerializeField]
    GameObject righthand;
    [SerializeField]
    Transform[] cheatroute;
    [SerializeField]
    Transform[] originroute;
    
    private void Start() {
        WhoIsFirst wif = lefthand.GetComponent<WhoIsFirst>();
        if(wif){
            wif.thisisFirst += SetCheat;
            wif.GetComponent<FlyToTarget>().SetPoints(originroute);
        }

        wif = righthand.GetComponent<WhoIsFirst>();
        if(wif){ 
            wif.thisisFirst += SetCheat;
            wif.GetComponent<FlyToTarget>().SetPoints(originroute);
        }
    }
    public void SetCheat(GameObject firsthand){
        WhoIsFirst wif;
        if(firsthand != lefthand){
            wif = lefthand.GetComponent<WhoIsFirst>();
            if(wif)Destroy(wif);
            else Debug.Log("왼손 없숴?");
            Debug.Log("왼손 지워");
        }
        if(firsthand != righthand){
            wif = righthand.GetComponent<WhoIsFirst>();
            if(wif) Destroy(wif);
            else Debug.Log("없다고?");
            Debug.Log("오른손 지워");
        }
        
    }
}
