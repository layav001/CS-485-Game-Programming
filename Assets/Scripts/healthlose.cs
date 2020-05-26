using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthlose : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public healthBar healbar;
    public Animator m_animator;
    public Collision2D col;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healbar.SetMaxHealth(maxHealth);
    }

    void dead()
    {
        m_animator.SetTrigger("Death");
       // gameObject.GetComponent<Animator>().enabled = false;
       gameObject.GetComponent<Bandit>().enabled = false;
       FindObjectOfType<GameManager>().EndGame();
    }
    public void takeDamage(int damage)
    { 
        currentHealth -= damage;
        healbar.SetHealth(currentHealth);
        m_animator.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            dead();

        }
    }
   void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            if (currentHealth <= 0)
            {
                dead();
            }
            else
            {
                takeDamage(10);
            }
        }
    }

}
