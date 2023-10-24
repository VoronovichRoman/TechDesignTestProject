using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class monster_flying_eye : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string _animationName;
    private Animator _animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger(_animationName);
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
}
