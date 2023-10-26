using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sound_manager : MonoBehaviour
{
    private string _sceneName;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _clips;
    void Start()
    {
        _sceneName = SceneManager.GetActiveScene().name;
        if (_sceneName == "first_scene_woods")
        {
            _audioSource.clip = _clips[0];            
        }
        else
        {
            _audioSource.clip = _clips[1];
        }
        _audioSource.Play();
    }
    public void SwordAttackSound()
    {
        _audioSource.PlayOneShot(_clips[2]);
    }
    public void SwordHitSound()
    {
        _audioSource.PlayOneShot(_clips[3]);
    }
    public void ChestOpenSound()
    {
        _audioSource.PlayOneShot(_clips[4]);
    }
    public void ChestPickUpSound()
    {
        _audioSource.PlayOneShot(_clips[5]);
    }
    public void RoadSignResizeSound()
    {
        _audioSource.PlayOneShot(_clips[6]);
    }
    public void MonsterFlyOnScreenSound()
    {
       _audioSource.PlayOneShot(_clips[7]);
    }
    public void FlyingEyeIsFlying()
    {
        _audioSource.PlayOneShot(_clips[8]);
    }
    public void ShopChatStart()
    {
        _audioSource.PlayOneShot(_clips[9]);
    }
    public void ButtonClick()
    {
        _audioSource.PlayOneShot(_clips[10]);
    }
}
