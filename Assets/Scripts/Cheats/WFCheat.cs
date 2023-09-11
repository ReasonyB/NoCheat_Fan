using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Waterfall))]
public class WFCheat : MonoBehaviour,ICheat
{
    private Cheats chnum = Cheats.NONE;
    private bool ison = true;

    public Cheats chNum{set => chnum = value; get => chnum;}
    public bool isOn{set => ison = value; get => ison;}
    
    [SerializeField]
    Waterfall wt;
    
    private void Start() {
        if(wt == null){
            Debug.LogError("WaterFall component is null in WFCheat Component");
        }
        CheatOn();
    }
    public void CheatOn(){
        wt.setDriection(-1);
        wt.setWaterPressure(25.0f);
        ison = true;
    }
    public void CheatOff(){
        if(ison){
            wt.setDriection(1);
            wt.setWaterPressure(5.0f);
            ison = false;
        }
    }
    public void Detected(){
        if(ison){

        }
    }
}
