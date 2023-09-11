using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowEmblemDetail : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private GameObject Detail;
    public void OnPointerEnter(PointerEventData eventdata)
    {
        gameObject.SetActive(false);
        Detail.SetActive(true);
    }
}
 