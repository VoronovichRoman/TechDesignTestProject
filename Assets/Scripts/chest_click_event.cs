using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class chest_click_event : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _hero;
    private Animator _animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger("isOpen");
        _hero.GetComponent<hero>().Move(this.transform.position.x);
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
}
