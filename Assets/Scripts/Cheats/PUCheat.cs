using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUCheat : MonoBehaviour, ICheat
{
    [SerializeField]
    PumpUp pu;
    [SerializeField]
    float PumpUpF = 25.0f;
    float originF;
    [SerializeField]
    Cheats chnum;
    bool ison = true;
    public bool isOn{get => ison;set => ison = value;}
    public Cheats chNum{get => chnum; set => chnum = value;}
    private void Start() {
        if(pu != null){
            CheatOn();
        }
    }
    public void CheatOn(){
        originF = pu.Impulse;
        pu.Impulse = PumpUpF;
        ison = true;
        pu.CheatEffect = () => CheatManager.Instance.EnableCheat(chnum);
    }
    public void CheatOff(){
        if(ison){
            pu.Impulse = originF;
            ison = false;
            pu.CheatEffect = null;
        }
    }
    public void Detected(){

    }
}
