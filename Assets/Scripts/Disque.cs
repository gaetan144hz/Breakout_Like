using System;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class Disque : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    public Vector2 direction;

    private Vector3 lastVelocity;

    public float time = 1f;

    public Quaternion startQuaternion;
    
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = transform.right * speed;
        rb.velocity = direction.normalized * speed;
    }

    private void Update()
    {
        lastVelocity = rb.velocity;
        startQuaternion = transform.rotation;
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        
        if (collision.gameObject.CompareTag("Brique"))
        {
            Vector3 hit = collision.contacts[0].point;
            Vector3 direction = new Vector3(transform.position.x, transform.position.y);
            
            var speed = lastVelocity.magnitude;
            
            float difference = direction.x - hit.x;

            if (hit.x < direction.x)
            {
                //rb.velocity = new Vector3(transform.position.x * difference * Time.deltaTime);
            }
        }

        else if (collision.gameObject.CompareTag("Arene"))
        {
            
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            
        }
        
        else if (collision.gameObject.CompareTag("DeathZone"))
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
        Time.timeScale = 0f;
    }
}
