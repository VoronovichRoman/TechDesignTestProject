using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_trigger_1 : MonoBehaviour
{
    [SerializeField] private GameObject _monster;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _monster.GetComponent<monster_flying_eye>().MonsterFlyingEyeActivation();
    }
}
