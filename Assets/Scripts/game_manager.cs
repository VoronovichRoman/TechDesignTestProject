using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class game_manager : MonoBehaviour
{
    [SerializeField] private GameObject _hero;
    private string _sceneName;
    void Start()
    {
        _sceneName = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if (_hero.transform.position.x >= 9.5f)
        {
            if (_sceneName == "first_scene_woods")
            {
                SceneManager.LoadScene("second_scene_cave");
            }
            else
            {
                SceneManager.LoadScene("first_scene_woods");
            }
        }
    }
    public void GoToNextScene()
    {
        _hero.GetComponent<hero>().Move(10f);
    }
}
