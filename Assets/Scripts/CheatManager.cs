using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheatManager : MonoBehaviour
{
    Cheats allcheat = Cheats.NONE;
    public static CheatManager Instance{get => instance;private set => instance = value;}
    private static CheatManager instance;

    [SerializeField] 
    TMP_Text CheatNumber;
    [SerializeField]
    TMP_Text CheatDetail;
    [SerializeField]
    Animator chEffectUI;
    [SerializeField]
    GameObject CheatEmblem;
    public int Count { private set; get; } = 0;
    
    private void Awake() {
        if(!instance) instance = this;
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.K)){
            EnableCheat(Cheats.Cheat000);
        }
    }
    private void countingCheat(){
        uint cheats = (uint)allcheat;
        Count = 0;
        while(cheats > 0){
            Count += (int)(cheats & 1);
            cheats = cheats >> 1;
        }
        CheatNumber.text = Count.ToString();
    }
    private void subcribingCheat(){
        string cheats;
        
    }
    private void cheatEffect(){
        chEffectUI.SetTrigger("Dang");
    }

    public void EnableCheat(Cheats num){
        if((allcheat & num) > 0) return;
        allcheat |= num;
        countingCheat();
        if(Count>0) CheatEmblem.SetActive(true);
        subcribingCheat();
        cheatEffect();
    }
    public void DisableCheat(Cheats num){
        allcheat &= ~num;
        countingCheat();
        if(Count == 0) CheatEmblem.SetActive(false);
        subcribingCheat();
    }

}
