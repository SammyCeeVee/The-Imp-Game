using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillOnTouch : MonoBehaviour {

    MoveLevel theLevel;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /*
     * Note: If OnTriggerStay, OnTriggerEnter, and OnTriggerExit are,
     * on the same class, only one of the will work. Use OnTriggerStay
     * on these type of classes as it is more reliable as it triggers on
     * every frame change.
     */
    void OnTriggerStay(Collider other)
    {
        KillPlayer(other);
        KillThis(other);
    }

    void KillThis(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }

    void KillPlayer(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level");
            Pause.isPaused = true;
            LevelProgression.gameTime = -1;
            ScorePlusser.score = 0;
        }
    }


}
