using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrofyZone : MonoBehaviour
{
    public GameObject[] obj;
    public string listenToTag = "Player";
    public Transform Point;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(listenToTag))
        {
            Trofy();
        }
    }
    public void Trofy()
    {

        Debug.Log("TrofySpavn");
        int random = Random.Range(0, obj.Length - 1);
        Instantiate(obj[random], Point.position, Quaternion.identity);
    }
}
