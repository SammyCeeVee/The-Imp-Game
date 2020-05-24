using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopExplosionAnimation : MonoBehaviour
{
    public float speed = 10;
    private float timer = 0.0f;
    public float endTime = 1f;
    // Start is called before the first frame update
    public Sprite finalExplosionImage;


    // Update is called once per frame
    void Update()
    {
        StopFalling();
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
    }

    private void StopFalling()
    {
        if (this.gameObject.transform.position.y >= -2.15f)
        {
            MoveDown();
        }
        else
        {
            Disappear();
        }
    }

    private void Disappear()
    {
        if (!Pause.isPaused)
        {
            timer += Time.deltaTime;
            if (timer >= endTime)
            {
                timer = 0;
                gameObject.SetActive(false);
            }
        }
    }   
}
