using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIsActive : MonoBehaviour
{
    public float fireTime = 0.5f;
    public GameObject gameObject;
    public bool isSpawned = false;
    public float timer;
    void Start()
    {
        //InvokeRepeating("Fire", fireTime, fireTime);


    }

    void FixedUpdate()
    {
        if (isSpawned == true)
        {
            timer += Time.deltaTime;

            if (timer >= fireTime)
            {
                Fire();
                timer = 0;
            }
        }
    }

    public void Fire()
    {
        GameObject obj = ObjectPooler.SharedInstance.GetPooledObject(gameObject.tag);


        if (obj == null) return;

        obj.transform.position = transform.position;
        //obj.transform.rotation = transform.rotation; //COMMENTING THIS FIXES THE AI ROTATION ISSUE 
        
        if (!Pause.isPaused)
        {
            obj.SetActive(true);
        }
    }
}
