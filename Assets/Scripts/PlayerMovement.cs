using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    private Controllers playerInput; // recupere le Input Action, attention au nom

    void Awake()
    {
        playerInput = new Controllers();
        rb = this.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }
    
    void Update()
    {
        
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public void OnMove(InputValue value)
    {
        //r�cup�rer l'action maps (**player**) puis l'Action (**move**) dans l'input action ATTENTION AU NOM !!!
        //Vector2 moveInput = playerInput.player.move.ReadValue<Vector2>();
        Vector2 moveInput = value.Get<Vector2>();
        rb.velocity = moveInput * speed;
    }
}
