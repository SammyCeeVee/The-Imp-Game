using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed = 0;
    public bool rotateRight = false;


	// Use this for initialization
	void Start ()
    {
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (!Pause.isPaused)
        {
            if (rotateRight)
                RotateRight();
            else RotateLeft();
        }
	}

    void RotateRight()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.back * Time.deltaTime * speed);
    }
}
