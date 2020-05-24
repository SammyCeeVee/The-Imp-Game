using UnityEngine;
using System.Collections;

public class BulletsAreActive : MonoBehaviour {

    public float fireTime = 1.5f;
    public float timer = 0.0f;
    public GameObject bullet;

    public void Update()
    {
        timer += Time.deltaTime;
        //#if (UNITY_EDITOR || UNITY_STANDALONE)
        FireForStandAlone();
        //  #endifz
    }

    public void Fire()
    {
        GameObject obj = ObjectPooler.SharedInstance.GetPooledObject(bullet.tag);
       
        if (obj == null) return;

        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation; 
            if (!Pause.isPaused)
            {      
                obj.SetActive(true);       
            }
    }

    void FireForStandAlone() 
    {
        if (Input.GetButton("Fire1") || Input.GetKey("space") || Input.GetKey("z")
       || Input.GetKeyDown("space") || Input.GetKeyDown("z"))
        {
            if (timer >= fireTime)
            {
                Fire();
                timer = 0;
            }
        }
    }
}
