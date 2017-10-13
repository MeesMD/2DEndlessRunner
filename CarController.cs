using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

	public float jetpackForce = 25.0f;
	public Rigidbody2D rb;
    public static bool Dead = false;
    private float dTravelled;
    private float Speed = 8f;
    

    void Start () {
		rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        dTravelled = DistanceScript.distanceTravelled;

        bool jetpackActive = (Input.GetKey("space"));
        jetpackActive = jetpackActive && !Dead;

        if (jetpackActive)
        {
            rb.AddForce(new Vector2(0, jetpackForce));
        }

        if (!Dead)
        {
            //Automatic movement
            Vector2 newVelocity = GetComponent<Rigidbody2D>().velocity;
            newVelocity.x = Speed;
            GetComponent<Rigidbody2D>().velocity = newVelocity;
        }

        if (dTravelled > 200)
        {
            Speed = 15f;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        HitByLaser(collider);
    }

    void HitByLaser(Collider2D laserCollider)
    {
        Dead = true;
        print("hit by laser!");
    }
}
