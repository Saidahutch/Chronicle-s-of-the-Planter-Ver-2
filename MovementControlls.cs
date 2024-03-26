using System;
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
        string[] game = {"Chronicle's of the Planter is an indie game", "It teaches people about plants benifits", "You play as a little gardner who is trying to fill in their garden"};
        for (int i = 0; i < game.Length; i++){
            Console.WriteLine(game[i]);
            
        }
      rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    //    move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 
        Console.WriteLine("demo");
    //     flip();
      string [] game = {"Chronicle's of the Planter is an indie game", "It teaches people about plants benifits", "You play as a little gardner who is trying to fill in their garden"};
        for (int i = 0; i < game.Length; i++){
            Console.WriteLine(game[i]);
        }

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

