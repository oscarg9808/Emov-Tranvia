using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTI : MonoBehaviour {

    public float movementSpeed = 25f;
    Vector3 TargetPosition;
    private float targetTime = 5.0f;
    private bool bandera = true;
    private float timer = 0.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (bandera)
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);

            if (transform.position.x < -430.10f)
            {
                TargetPosition = transform.position;
                TargetPosition.x += 500.50f;
                transform.position = TargetPosition;
            }
        }
    }
}
