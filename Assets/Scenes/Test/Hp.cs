using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
