using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpsControler : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] int jumpPower = 150;
    bool canJump = true; // Flag to track if the character can jump

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump) // Only jump if canJump is true
        {
            rb.AddForce(Vector2.up * jumpPower);
            canJump = false; // Set canJump to false after the jump
        }
    }

    // Function to allow jumping again when the character lands (optional)
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") // Check if collided with ground
        {
            canJump = true; // Reset canJump when character lands
        }
    }
}
