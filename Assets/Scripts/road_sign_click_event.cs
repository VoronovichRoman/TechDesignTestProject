using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class road_sign_click_event : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _nextSceneButton;
    [SerializeField] private GameObject _hero;
    public void OnPointerClick(PointerEventData eventData)
    {
        _hero.GetComponent<hero>().Move(this.transform.position.x);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _nextSceneButton.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _nextSceneButton.SetActive(false);
    }
}
