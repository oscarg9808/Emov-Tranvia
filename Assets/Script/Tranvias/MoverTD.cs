using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTD : MonoBehaviour
{
    private float movementSpeed = 1;
    Vector3 TargetPosition;
    private float targetTime = 5.0f;
    private bool bandera = true;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bandera)
        {
            transform.Translate(-Vector3.left * Time.deltaTime * movementSpeed);

            if (transform.position.x > 4.00f)
            {
                TargetPosition = transform.position;
                TargetPosition.x -= 18f;
                transform.position = TargetPosition;
            }
        }

        /*if (transform.position.x < 2.6f && transform.position.x > 1.6f)
        {
            //correcto
            bandera = false;
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer > 5.0f)
            {
                bandera = true;
                timer = 0.0f;
            }

        }
        else if (transform.position.x > 250.0f)
        {
            TargetPosition = transform.position;
            TargetPosition.x -= 800f;
            transform.position = TargetPosition;
        }*/

    }
}
