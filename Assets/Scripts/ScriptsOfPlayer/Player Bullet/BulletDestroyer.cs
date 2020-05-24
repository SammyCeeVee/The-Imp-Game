using UnityEngine;
using System.Collections;

public class BulletDestroyer : MonoBehaviour {

    public float bulletDistance = 2f;

    void OnEnable()
    {
        Invoke("Destroy", bulletDistance);
    }

    void Destroy()
    {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke();
    }

    void OnTriggerStay(Collider other)
    {
        gameObject.SetActive(false);
        if (other.gameObject.CompareTag("Rocks")
            || other.gameObject.CompareTag("Enemy00")
            || other.gameObject.CompareTag("FrostMtn")
            || other.gameObject.CompareTag("SnowStalagmites")
            || other.gameObject.CompareTag("Enemy01")
            || other.gameObject.CompareTag("RockBank")
            || other.gameObject.CompareTag("GreenBush")
            || other.gameObject.CompareTag("EnemyCannon")
            || other.gameObject.CompareTag("CherubEnemy")
            || other.gameObject.CompareTag("BlackHoleEnemy")
            || other.gameObject.CompareTag("TurtleEnemy")
            || other.gameObject.CompareTag("EnemySpider")
            || other.gameObject.CompareTag("BatEnemy"))
        {
            //Instantiate an explosion if we hit any of the enemies above
            GameObject obj = ObjectPooler.SharedInstance.GetPooledObject("Explosion0");
            
            if (obj == null) return;
            //Do the instance of the explosion at the bullet location
            obj.transform.position = transform.position;
            //obj.transform.rotation = transform.rotation; //COMMENTING THIS FIXES THE AI ROTATION ISSU

            //but only if the game is unpaused
            if (!Pause.isPaused)
            {
                other.gameObject.SetActive(false);
                obj.SetActive(true);
            }

            ScorePlusser.score += 10;
        }

    }
}
