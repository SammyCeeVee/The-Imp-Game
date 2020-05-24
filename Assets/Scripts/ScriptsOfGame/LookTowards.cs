using UnityEngine;
using System.Collections;

public class LookTowards : MonoBehaviour {

    public Transform target;
    void Start()
    {
      
    }
    void Update()
    {
        transform.LookAt(target);
    }
}

