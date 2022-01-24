using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class briqueDestroy : MonoBehaviour
{
    [SerializeField] private GameObject deathEffect;

    [SerializeField] private GameObject DeathEffectPrefabs;
    
    private Rigidbody2D rb;
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Balle"))
        {
            Die();
        }
    }

    public void Die()
    {
        DeathEffectPrefabs = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(DeathEffectPrefabs,1f);
        Destroy(this.gameObject);
    }
}
