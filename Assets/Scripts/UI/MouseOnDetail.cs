using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOnDetail : MonoBehaviour, /*IPointerUpHandler,*/ IPointerExitHandler
{   
    [Tooltip("엠블럼이 있는 객체, 디테일 창과 스위칭 용")]
    [SerializeField]
    GameObject Emblem;
    [Tooltip("디테일 창이 차오르고 사라지는 속도")]
    [SerializeField]
    float speed = 0.2f;
    float finalxpos = 0f;
    float originxpos;
    RectTransform rtform;
    private void Awake() {
        rtform = transform as RectTransform;
        originxpos = rtform.anchoredPosition.x;
#if DEBUG
        Debug.Log($"{rtform.anchoredPosition.x}");
#endif
    }
    private void Update() {
        float onstep = speed * Time.deltaTime * 100f;
        onstep *= ((finalxpos - rtform.anchoredPosition.x) > 0 ? 1 : -1); 
        if(rtform.anchoredPosition.x != finalxpos){
            rtform.anchoredPosition = new Vector2(Mathf.Clamp(rtform.anchoredPosition.x + onstep,0f,originxpos), 0f);
        }
        else if(finalxpos == originxpos){
            OnMoved();
        }
    }
    private void OnEnable() {
       finalxpos = 0f;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        finalxpos = originxpos;
    }
    /// <summary>
    /// 디테일 창이 나오거나 전부 사라진 이후, 엠블럼을 띄우고 디테일 창을 숨기는 역할(추후 수정 가능)
    /// </summary>
    private void OnMoved(){
        gameObject.SetActive(false);
        Emblem.SetActive(true);
    }
}
