using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class shop_click_event : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _hero;
    public void OnPointerClick(PointerEventData eventData)
    {
        _hero.GetComponent<hero>().Move(-1);
    }
}
