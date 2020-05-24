using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

    public float playerSpeed = 4;
    public GameObject player;
    float yAxis;
    float xAxis;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
    #if (UNITY_EDITOR || UNITY_STANDALONE)
        if (!Pause.isPaused)
        {
            JoyStickControls();
        }
    #endif
    }

    public void JoyStickControls()
    {
        yAxis = Input.GetAxis("Vertical") * -playerSpeed;
        xAxis = Input.GetAxis("Horizontal") * playerSpeed;

        yAxis *= Time.deltaTime;
        transform.Translate(0, yAxis, 0);

        xAxis *= Time.deltaTime;
        transform.Translate(xAxis, 0, 0);

    }

    public void MoveRight()
    {
        player.transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);
    }

    public void MoveLeft()
    {
        player.transform.Translate(Vector3.left * Time.deltaTime * playerSpeed);
    }

    public void MoveUp()
    {
        player.transform.Translate(Vector3.down * Time.deltaTime * playerSpeed);
    }

    public void MoveDown()
    {
        player.transform.Translate(Vector3.up * Time.deltaTime * playerSpeed);
    }
}
