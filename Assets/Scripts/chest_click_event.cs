using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class chest_click_event : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _hero;
    [SerializeField] private GameObject _sooundManager;
    private Animator _animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger("isOpen");
        _hero.GetComponent<hero>().Move(this.transform.position.x);
        _sooundManager.GetComponent<sound_manager>().ChestOpenSound();
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _animator.SetTrigger("isPickUp");
        _hero.GetComponent<hero>().Move(this.transform.position.x);
        _sooundManager.GetComponent<sound_manager>().ChestPickUpSound();
    }

    private void DestroyChest()
    {
        Destroy(gameObject);
    }
}
