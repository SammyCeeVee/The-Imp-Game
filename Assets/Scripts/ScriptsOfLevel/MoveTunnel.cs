using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveTunnel : MonoBehaviour {

    public Material theMaterial;
    public float speed = 0;

    // Use this for initialization
    void Start ()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        MoveStraight();
    }

    public void MoveStraight()

    {
        if (!Pause.isPaused)
        {
            float offset = Time.time * speed;
            theMaterial.SetTextureOffset("_MainTex", new Vector2(0, offset)); ;
        }
    }
}
	
	
