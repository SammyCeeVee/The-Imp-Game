using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResetter : MonoBehaviour {

    public LevelProgression theProgression;


    public float forestFromInitial = 500;
    public float forestToInitial = 900;
    public float forestEveryInitial = 0;


    public float skullFromInitial = 500;
    public float skullToInitial = 900;
    public float skullEveryInitial = 1000;

    // Use this for initialization
    void Start ()
    {
        StoreInitialValues();
    }
	
	// Update is called once per frame
	void Update ()
    {
	}

    public void ResetGame()
    {

        theProgression.gameEnded = true;

            if (theProgression.gameEnded)
            {
                LevelProgression.gameTime = 0;
                theProgression.isLevel = 1;

                theProgression.forestTo = forestToInitial;
                theProgression.forestFrom = forestFromInitial;
                theProgression.forestEvery =  forestEveryInitial;

                theProgression.skullTo = skullToInitial;
                theProgression.skullFrom = skullFromInitial;
                theProgression.skullEvery =  skullEveryInitial;
            
                theProgression.gameEnded = false;
            }
    }

    void StoreInitialValues()
    {

        forestFromInitial = theProgression.forestFrom;
        forestToInitial = theProgression.forestTo;
        forestEveryInitial = theProgression.forestEvery;

        skullFromInitial = theProgression.skullFrom;
        skullToInitial = theProgression.skullTo;
        skullEveryInitial = theProgression.skullEvery;
    }
}
