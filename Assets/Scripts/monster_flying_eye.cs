using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class monster_flying_eye : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _hero;
    [SerializeField] private string _animationTriggerName;
    [SerializeField] private GameObject _sooundManager;
    private Animator _animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        MonsterFlyingEyeActivation();
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
        _animator.SetTrigger("isDead");
        _sooundManager.GetComponent<sound_manager>().SwordAttackSound();
        _sooundManager.GetComponent<sound_manager>().SwordHitSound();
        _hero.GetComponent<hero>().Move(this.transform.position.x);        
    }

    public void MonsterFlyingEyeActivation()
    {
        _animator.SetTrigger(_animationTriggerName);
        _sooundManager.GetComponent<sound_manager>().FlyingEyeIsFlying();
        if (_animationTriggerName == "isFlyOnScreen")
        {
            _sooundManager.GetComponent<sound_manager>().MonsterFlyOnScreenSound();
        }
    }
}
