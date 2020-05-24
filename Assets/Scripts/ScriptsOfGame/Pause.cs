using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public static bool isPaused = true;

    void OnMouseDown()
    {
        isPaused = false;
        MoveSky.skySpeed = -0.1F;
    }

    void Update()
    {
        Unpause();
    }

    void Unpause()
    {
        if (Input.GetKeyDown("return") || Input.GetButtonDown("Fire1"))
        {
            isPaused = false;
            MoveSky.skySpeed = -0.1F;
        }
    }
}

