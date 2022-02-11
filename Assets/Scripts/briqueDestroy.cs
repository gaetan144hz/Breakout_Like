using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AudioSource))]

public class briqueDestroy : MonoBehaviour
{
    [SerializeField] private GameObject deathEffect;

    [SerializeField] private GameObject DeathEffectPrefabs;
    
    private Rigidbody2D rb;

    private AudioSource audioSource;
    
    void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
        
        rb = this.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        audioSource.Play();
        
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
