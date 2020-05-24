using UnityEngine;
using System.Collections;

public class MovePlayerBullet : MonoBehaviour {

    public float speed = 12;
    public float rotationSpeed = 80;
    void Update()
    {
        Moving();
        Rotate();
    }

    public void Moving()

    {
        transform.Translate(-Vector3.forward * Time.deltaTime * speed, Space.World);
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
