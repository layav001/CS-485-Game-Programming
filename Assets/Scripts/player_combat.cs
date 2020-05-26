using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_combat : MonoBehaviour
{
    public Animator m_animator;
    public Transform attackpoint;
    public LayerMask enemyLayers;

    public float attackRange = .5f;
    public int attackDamage = 20;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }
    void Attack()
    {
        m_animator.SetTrigger("Attack"); //plays attack animation

        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitenemies)
        {
            enemy.GetComponent<enemy_death>().edamage(attackDamage);
            enemy.GetComponent<slime_death>().sdamage(attackDamage);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;
        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }
}
