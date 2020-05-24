using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazySpawnerPos : MonoBehaviour
{
    
    public GameObject prefab;
    public bool isGoldObjectBeingSpawned = false;
    //public float yPositionOfObject = 0.42f;

    public float minimumYPos = 0;
    public float maximumYPos= 0;

    public float minimumXPos = 17.61f;
    public float maximumXPos = -14.52f;

    public float zPositionOfObject = -37.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {//OG x-coordinates = (5.87f to -4.84f) //New x-coordinates (11.74f, -14.52f)
        Vector3 position = new Vector3(Random.Range(minimumXPos, maximumXPos), Random.Range(minimumYPos, maximumYPos),
            zPositionOfObject);


        prefab.transform.position = position;
    }
}
