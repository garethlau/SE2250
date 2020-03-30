﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool hasHealthBar = false;
    public int maxHealth = 10;
    public float currhealth;
    public SimpleHealthBar healthBar;
    public GameObject expCube;
    private Animator animator;


    public bool isDead = false;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        currhealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currhealth-= amount;
        if (hasHealthBar)
        {
            healthBar.UpdateBar(currhealth, maxHealth);
        }
        if (currhealth <= 0)
        {
            print("Died");
            isDead = true;
            animator.SetBool("isDead", true);
            //dropping exp orb
            Instantiate(expCube, transform.position, transform.rotation);
        }
        else
        {
            print("Took damage");
            animator.SetTrigger("hit");
        }
    }
}
