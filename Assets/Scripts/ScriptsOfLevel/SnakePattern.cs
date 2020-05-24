using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakePattern : MonoBehaviour
{

    public float timer;
    public float speed;
    public float range;
    public bool goingUp;

    public int randomStart;

    void Awake()
    {
        randomStart = (int) Random.Range(0, 2);

        if (randomStart == 0)
        {
            goingUp = true;
        }
        else
        {
            goingUp = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!Pause.isPaused)
        {
            ToggleTime();
            ZigZag();
        }
    }


    void ToggleTime()
    {
        if (goingUp)
        {
            timer += Time.deltaTime;
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else
        {
            timer -= Time.deltaTime;
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }

    void ZigZag()
    {
        if (timer >= range)
        {
            goingUp = false;
        }
        else if(timer <= -range)
        {
            goingUp = true;
        }
               
    }
}
