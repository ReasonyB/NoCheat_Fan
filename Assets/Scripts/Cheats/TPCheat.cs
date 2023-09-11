using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCheat : MonoBehaviour,ICheat
{
    [SerializeField]
    Transform MovePoint;
    Cheats chno = Cheats.Cheat000;
    bool ison = true;
    public Cheats chNum {get => chno; set => chno = value;}
    public bool isOn {get => ison; set => ison = value;}

    public void CheatOff()
    {
        ison = false;
        CheatManager.Instance.DisableCheat(Cheats.Cheat000);
    }

    public void CheatOn()
    {
        ison = true;
        CheatManager.Instance.EnableCheat(Cheats.Cheat000);
    }

    public void Detected()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" & ison){
            other.transform.position = MovePoint.position;
            CheatOn();
        }
    }
}
