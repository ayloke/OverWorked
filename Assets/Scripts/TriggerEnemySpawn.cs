using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float distance = 1.5f;
    public string listenToTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(listenToTag))
        {
            Debug.Log("ok");
            Instantiate(enemyPrefab, Random.insideUnitCircle * distance, Quaternion.identity);
            Instantiate(enemyPrefab, Random.insideUnitCircle * distance, Quaternion.identity);
            Instantiate(enemyPrefab, Random.insideUnitCircle * distance, Quaternion.identity);
            Instantiate(enemyPrefab, Random.insideUnitCircle * distance, Quaternion.identity);
        }
    }
}
