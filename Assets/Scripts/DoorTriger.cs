using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTriger : MonoBehaviour
{
    public void OnTriggerEnter()
    {
       GetComponent<MeshRenderer>().enabled = false;
          
    }
    public void OnTriggerExit()
    {
       GetComponent<MeshRenderer>().enabled = true;
    }
}