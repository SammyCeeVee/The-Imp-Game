using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayerX : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    public GameObject player;

    public float speed = 0;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Move our position a step closer to the target.
        float step = speed * Time.deltaTime; // calculate distance to move

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x,
            this.transform.position.y, this.transform.position.z), step);
    }
}
