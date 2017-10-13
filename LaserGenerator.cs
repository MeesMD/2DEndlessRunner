using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGenerator : MonoBehaviour {

    float maxY = -4;
    float minY = 4;
    public GameObject theLaser;
    public Transform generationPointLaser;
    public float distanceBetweenLaser;
	private float dTravelled;
    public float laserRotate;
    public float laserInterval;
    

    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < generationPointLaser.position.x)
        {
            transform.position = new Vector3(transform.position.x + distanceBetweenLaser, transform.position.y, transform.position.z);

            float laserHeight = Random.Range(minY, maxY);
            Instantiate(theLaser, new Vector3(transform.position.x, laserHeight, 0), transform.rotation);
        }

    }

	void FixedUpdate (){

		dTravelled = DistanceScript.distanceTravelled;

		if (dTravelled > 100) {
            distanceBetweenLaser = 13;         
		}
	}
}
