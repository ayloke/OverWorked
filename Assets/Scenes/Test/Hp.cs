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
    private void Start()
    {
        currentHealth = maxHealth;
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            NewGame();
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (Time.time >= nextDamageTime)
        {
            if (collisionInfo.collider.tag == "Enemy")
            { 
                Debug.Log("hit");
                //currentHealth --;
                TakeDamage(enemyDamage);
                nextDamageTime = Time.time + 1f / damageRate;
            }
        }
    }
    //Не работает неуязвиость после получения урона
    void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        this.enabled = false;
        Destroy(gameObject);
        //SceneManager.LoadScene("lobby"); Надо потом включить чтобы отправлять игрокав лобби
        Debug.Log("Player Die");
    }
}
