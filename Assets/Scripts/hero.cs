using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class hero : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float _moveSpeed;
    private bool _moveIsActive;
    private float _destenation;
    private Animator _anim;
    private bool _isFacingRight;
    public void OnPointerClick(PointerEventData eventData)
    {
        _anim.SetTrigger("isAttack");
    }
    void Start()
    {
        _moveIsActive = false;
        _anim = GetComponent<Animator>();
        _destenation = 0f;
        _isFacingRight = true;
        Move(-6);
    }
    void Update()
    {
        if (_moveIsActive)
        {
            HorizontalMovement(_destenation);
        }
    }
    public void Move(float destenation)
    {
        if (destenation < this.transform.position.x && _isFacingRight)
        {
            Flip();
        }
        else if (destenation > this.transform.position.x && !_isFacingRight)
        {
            Flip();
        }
        _anim.SetBool("isRun", true);
        _moveIsActive = true;
        _destenation = destenation;
    }
    private void HorizontalMovement(float destenation)
    {

        Vector3 tempPosition = this.transform.position;
        tempPosition.x = Mathf.MoveTowards(tempPosition.x, destenation, _moveSpeed * Time.deltaTime);

        this.transform.position = tempPosition;
        if (this.transform.position.x >= destenation && _isFacingRight)
        {
            _moveIsActive = false;
            _anim.SetBool("isRun", false);
        }
        else if (this.transform.position.x <= destenation && !_isFacingRight)
        {
            _moveIsActive = false;
            _anim.SetBool("isRun", false);
        }
    }
    private void Flip()
    {
        _isFacingRight = !_isFacingRight;
        Vector3 tempScale = this.transform.localScale;
        tempScale.x *= -1;
        this.transform.localScale = tempScale;
    }
}
