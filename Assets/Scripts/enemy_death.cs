using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemy_death : MonoBehaviour
{
    private int maxhealth = 20;
    private int currenthealth;

    public Animator ani;

    void Start()
    {
        currenthealth = maxhealth;
    }
    public void edamage(int damage)
    {
        currenthealth -= damage;
        ani.SetTrigger("enemy_hit");

        if (currenthealth <= 0)
        {
            died();
        }
    }
    void died()
    {
        ani.SetBool("isDead", true);
        GetComponent<Collider2D>().enabled = false;
        GetComponent<enemy_beh2>().enabled = false;
    }

}
