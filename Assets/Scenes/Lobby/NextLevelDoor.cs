using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelDoor : MonoBehaviour
{
    //������ ������ �����
    public void OnTriggerEnter ()
    {
        SceneManager.LoadScene("Floor1");
    }
}