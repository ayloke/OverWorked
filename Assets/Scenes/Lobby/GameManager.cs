using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public void OnTriggerEnter ()
    {
        SceneManager.LoadScene("Floor1");
    }
}