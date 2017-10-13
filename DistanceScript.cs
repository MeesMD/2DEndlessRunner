using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScript : MonoBehaviour {

    public Text textDistance;
    public static float distanceTravelled = 0;
	public float speed;
    Vector3 lastPosition;

    // Use this for initialization
    void Start ()
    {
        lastPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;

        textDistance.text = distanceTravelled.ToString("F0") + " Meter";

    }
}
