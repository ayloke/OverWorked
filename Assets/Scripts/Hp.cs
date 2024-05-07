using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.PlasticSCM.Editor.WebApi;
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
    {//неуязвимость после получения урона
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        this.enabled = false;
        Destroy(gameObject);
        //SceneManager.LoadScene("lobby"); Надо потом включить чтобы отправлять игрока в лобби
        Debug.Log("Player Die");
    }
}
