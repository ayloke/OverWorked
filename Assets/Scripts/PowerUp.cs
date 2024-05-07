using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public int currentHpUp = 100;
    public int enemyDamage = 1;//деление
    public int attackDamage = 5;//умножение
    public int attackRate = 1;// умножение 
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
            Combat(other);
        }
    }
    void Pickup(Collider player)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        Player stats = player.GetComponent<Player>();
        stats.currentHealth += currentHpUp;
        stats.enemyDamage /= enemyDamage;
        
        Debug.Log("Power Up picked up");

        Destroy(gameObject);
    }
    void Combat (Collider player)
    {
        Combat stats = player.GetComponent<Combat>();
        stats.attackDamage *= attackDamage;
        stats.attackRate *= attackRate;
    }
}

