using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragInitializer : MonoBehaviour
{
    // Start is called before the first frame update

    public DragRigidbody2 drag;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        drag.Initiate();
    }

    private void OnMouseOver()
    {
        drag.Initiate();
    }
}
