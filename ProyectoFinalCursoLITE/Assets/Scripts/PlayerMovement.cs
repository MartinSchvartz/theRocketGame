using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed= 10.0f;
    public Vector2 movement;

  

    public float runSpeed = 20.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }
    void FixedUpdate()
    {
        MoveCharacter(movement);
    }
    void MoveCharacter(Vector2 direccion)
    {
        rb.velocity = direccion * speed;
    }

}
