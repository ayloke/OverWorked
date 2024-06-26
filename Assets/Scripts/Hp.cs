using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int enemyDamage = 20;
    public float damageRate = 2f;
    float nextDamageTime = 0;
    public HealthBar healthBar;
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            NewGame();
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {//������������ ����� ��������� �����
        if (Time.time >= nextDamageTime)
        {
            if (collisionInfo.collider.tag == "Enemy")
            { 
                Debug.Log("hit");
               
                TakeDamage(enemyDamage);
                nextDamageTime = Time.time + 1f / damageRate;
            }
        }
    }
    
    void NewGame()
    {
        this.enabled = false;
        Destroy(gameObject);
        SceneManager.LoadScene("Mainmenu");
        Debug.Log("Player Die");
    }
}
