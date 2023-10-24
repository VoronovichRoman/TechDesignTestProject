using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class road_sign_click_event : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _nextSceneButton;
    [SerializeField] private GameObject _hero;
    private Animator _animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger("isResize");
        _hero.GetComponent<hero>().Move(this.transform.position.x);
    }
    private void Start()
    {
        _animator = GetComponent<Animator>();
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
