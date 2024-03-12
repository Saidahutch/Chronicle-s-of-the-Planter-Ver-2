using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Vector2 move;
    public float speed = 10.0f;
    Rigidbody2D rb;
    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    //    move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 

    //     flip();

        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 newPosition = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        transform.position = newPosition;


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);
    }
    void flip()
    {
        if (move.x < -0.01f) transform.localScale = new Vector3(-1, 1, 1);
        if (move.x > 0.01f) transform.localScale = new Vector3(1, 1, 1);
    }
}

