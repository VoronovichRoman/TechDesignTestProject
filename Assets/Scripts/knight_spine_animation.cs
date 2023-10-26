using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight_spine_animation : MonoBehaviour
{
    private float _destenation;
    private void Start()
    {
        _destenation = -10f;
    }
    void Update()
    {
        Vector3 tempPosition = this.transform.position;
        tempPosition.x = Mathf.MoveTowards(tempPosition.x, _destenation, 2 * Time.deltaTime);
        if (tempPosition.x >= 10f)
        {
            _destenation = -10f;
            Flip();
        }
        else if (tempPosition.x <= -10f)
        {
            _destenation = 10f;
            Flip();
        }
        this.transform.position = tempPosition;
    }
    private void Flip()
    {
        Vector3 tempScale = this.transform.localScale;
        tempScale.x *= -1;
        this.transform.localScale = tempScale;
    }
}
