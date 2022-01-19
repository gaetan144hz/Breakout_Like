using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class briqueDestroy : MonoBehaviour
{
    private Rigidbody2D rb;
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Balle"))
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
