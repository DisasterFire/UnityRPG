using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float xMove = 10f;
    public float yMove = 10f;
    public float speed = 10f;
    Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
    }

    void CheckMovement()
    {
        xMove = Input.GetAxis("Horizontal") * speed;
        yMove = Input.GetAxis("Vertical") * speed;
    }

    void Movement()
    {
        Vector2 newVelocity = new Vector2(xMove, yMove);
        player.velocity = newVelocity;
    }

    void FixedUpdate()
    {
        Movement();
    }

}
