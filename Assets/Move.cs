using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D player;
    float horizontal;
    float vertical;
    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        player.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
} // Simple move script for WASD
