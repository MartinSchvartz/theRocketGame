using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour {
    public Transform transform;
    public Rigidbody2D rb;
    public float Velocidad=1, maxVelocidad=1;
	// Use this for initialization
	
	
	// Update is called once per frame
    //Arreglar

	void FixedUpdate () {
        rb.AddForce(Vector2.right * Velocidad);
        float VelocidadLimite = Mathf.Clamp(rb.velocity.x, -maxVelocidad, maxVelocidad);
        rb.velocity = new Vector2(VelocidadLimite, rb.velocity.y);
        if (rb.position.x<22|| rb.position.x>26)
        {
            Velocidad = -Velocidad;
        }
	}
}
