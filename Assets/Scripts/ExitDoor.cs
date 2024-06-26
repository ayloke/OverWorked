using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public string LevelName = "Level_2";
    public string listenToTag = "Player";
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(listenToTag))
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
