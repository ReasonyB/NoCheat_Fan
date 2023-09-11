using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTTCheat : MonoBehaviour, ICheat
{
    FlyToTarget ftt;
    List<Vector3> originroute;
    List<Vector3> cheatroute;
    Cheats chnum;
    bool ison = true;
    public bool isOn{get => ison; set => ison = value;}
    public Cheats chNum{get => chnum; set => chnum = value;}
    
    public void CheatOn(){
        if(ftt){
        }
    }
    public void CheatOff(){

    }
    public void Detected(){

    }
}
