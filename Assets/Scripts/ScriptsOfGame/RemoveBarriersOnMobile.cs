using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBarriersOnMobile : MonoBehaviour
{
    public GameObject barrierLeft;
    public GameObject barrierRight;
    // Start is called before the first frame update
    void Awake()
    {
#if (UNITY_IOS || UNITY_ANDROID)
        barrierLeft.SetActive(false);
        barrierRight.SetActive(false);
#endif
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }
}
