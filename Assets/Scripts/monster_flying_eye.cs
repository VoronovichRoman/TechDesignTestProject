using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class monster_flying_eye : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _hero;
    public string _animationName;
    private Animator _animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger(_animationName);
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void DestroyMonster()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _hero.GetComponent<Animator>().SetTrigger("isAttack");
        _hero.GetComponent<hero>().Move(this.transform.position.x);
        _animator.SetTrigger("isDead");
    }
}
