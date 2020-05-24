using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

    public float speed = 8;

    public bool moveForwardDiagonally = false;
    public bool moveRight = false;
    public bool moveLeft = false;

    private void OnEnable()
    {
        SetAllChildrenActive();
    }

    void Update()
    {
        Moving();
        MovingDiagonally();
    }

    public void Moving()

    {
        if (!Pause.isPaused)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        }
    }

    public void MovingDiagonally()

    {
        if (moveForwardDiagonally)
        {
            Moving();
            if(moveLeft)
                transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
            if(moveRight)
                transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }
    }

    void SetAllChildrenActive()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (!gameObject.transform.GetChild(i).gameObject.activeSelf)
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
