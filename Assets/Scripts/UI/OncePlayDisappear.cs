using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncePlayDisappear : MonoBehaviour
{
    Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
    }

}
