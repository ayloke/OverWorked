using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDie : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) 
        {
            Die();
        }
    }
     void Die ()
    {
        Debug.Log("Enemy died!");
        this.enabled = false;   
        Destroy(gameObject);
        //GetComponent<Collider>().enabled = false;
        //GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<NavMeshAgent>().enabled = false;
        //GetComponent<Enemy>().enabled = false;
    }
}
