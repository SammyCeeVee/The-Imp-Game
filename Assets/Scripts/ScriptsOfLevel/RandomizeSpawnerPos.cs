using UnityEngine;
using System.Collections;

public class RandomizeSpawnerPos : MonoBehaviour {

    // Use this for initialization
    public GameObject prefab;
    public float yPositionOfObject = 0.42f;
    public float zPositionOfObject = -37.5f;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {//OG x-coordinates = (5.87f to -4.84f) //New x-coordinates (11.74f, -14.52f)
        Vector3 position = new Vector3(Random.Range(17.61f, -14.52f), yPositionOfObject,
            zPositionOfObject);
        

        prefab.transform.position = position;
    }
}
