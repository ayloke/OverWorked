using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    public GameObject FakeDoor;
    public string listenToTag = "Player";
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(listenToTag))
        {
            GetComponent<MeshRenderer>().enabled = false;
            //FakeDoor.GetComponent<MeshRenderer>().enabled = false;
            FakeDoor.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(listenToTag))
        {
            GetComponent<MeshRenderer>().enabled = true;
            //FakeDoor.GetComponent<MeshRenderer>().enabled = true;
            FakeDoor.GetComponent<BoxCollider>().enabled = true;
        }
    }
}