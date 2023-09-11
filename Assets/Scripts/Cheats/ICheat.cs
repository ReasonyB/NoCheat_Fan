using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICheat
{
    Cheats chNum{set;get;}
    bool isOn{set;get;}
    public void CheatOn();
    public void CheatOff();
    public void Detected(); 
}
