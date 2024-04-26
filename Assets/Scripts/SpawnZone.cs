using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public GameObject[] obj;
    public string listenToTag = "Player";
    //public float distance1 = 1.5f;
    //public float distance2 = 1.5f;
    public Transform Point;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(listenToTag))
        {
            Spawn();
        }
    }



    public void Spawn()
    {

        Debug.Log("ok");
        int random = Random.Range(0, obj.Length - 1);
        Instantiate(obj[random], Point.position, Quaternion.identity);
        //* Random.Range(distance1,distance2)
    }
}