using UnityEngine;
using System.Collections;

public class KillnetKillOnTouch : MonoBehaviour {

    public float yAxisKiller;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            other.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
    }

    void KillAtYAxis()
    {

        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
        {
            if (go.transform.position.y <= yAxisKiller && !go.gameObject.CompareTag("Player"))
            {
                go.gameObject.SetActive(false);
            }
        }
    }
}
