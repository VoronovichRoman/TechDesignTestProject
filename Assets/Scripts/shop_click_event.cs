using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class shop_click_event : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _hero;
    [SerializeField] private GameObject _chatBubble;
    [SerializeField] private GameObject _road_sign;
    public void OnPointerClick(PointerEventData eventData)
    {        
        _hero.GetComponent<hero>().Move(-1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _road_sign.GetComponent<Animator>().SetTrigger("isResize");
        _chatBubble.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _chatBubble.SetActive(false);
    }
}
