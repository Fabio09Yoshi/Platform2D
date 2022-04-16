using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animEnemy;
    
    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animEnemy.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        //Die Animation;
        animEnemy.SetBool("isDead", true);

        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<CircleCollider2D>().enabled = false;
        this.enabled = false;
    }
}
