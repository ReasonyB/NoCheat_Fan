using System;
using System.Collections;
using System.Collections.Generic;

[Flags]
public enum Cheats{
    NONE = 0,
    Cheat000 = 1,
    Cheat001 = 1<<1,
    Cheat002 = 1<<2,
    All = int.MaxValue
};