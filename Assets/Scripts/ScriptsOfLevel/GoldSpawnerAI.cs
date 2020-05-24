using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawnerAI : MonoBehaviour
{
    public int levelDice;

    public int levelDiceResult;
    public float levelDistanceDiceResult;

    public LevelProgression theLevelProgression;
    public ObjectIsActive goldActivator;

    public int progressChecker;
    public int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = theLevelProgression.isLevel;
        progressChecker = currentLevel;

        //This whole program only works if gold firetime is 0
        goldActivator.fireTime = 0;
    }

    // Update is called once per frame
    void Update()
    {

        ShootGold();
        //Keep checking if the level changed
        progressChecker = theLevelProgression.isLevel;

        //If it changed...
        if (progressChecker != currentLevel)
        {

            goldActivator.isSpawned = false;

            //Roll the dice...
            DiceRoller();

            //Then keep track of the change...
            currentLevel = theLevelProgression.isLevel;
        }

    }

    void DiceRoller()
    {
        if (theLevelProgression.isLevel == 1)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelOne, theLevelProgression.levelTwo - theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 2)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelTwo, theLevelProgression.levelThree - theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 3)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelThree, theLevelProgression.levelFour - theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 4)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelFour, theLevelProgression.levelFive- theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 5)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelFive, theLevelProgression.levelSix - theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 6)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelSix, theLevelProgression.levelSeven - theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 7)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelSeven, theLevelProgression.levelEight- theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 8)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelEight, theLevelProgression.levelNine - theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 9)
        {
            levelDiceResult = Random.Range(1, levelDice+1);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelNine, theLevelProgression.levelTen - theLevelProgression.restTimeBetweenLvls);

        }

        else if (theLevelProgression.isLevel == 10+1)
        {
            levelDiceResult = Random.Range(1, levelDice);
            levelDistanceDiceResult = Random.Range(theLevelProgression.levelTen, theLevelProgression.gameEnd - theLevelProgression.restTimeBetweenLvls);

        }
    }

    void ShootGold()
    {
        //If dice results in one, it is a win, so shoot a nugget
        if (levelDiceResult == 1)
        {

            if (LevelProgression.gameTime >= levelDistanceDiceResult)
            {
                //This only works if gold firetime is 0

                    goldActivator.Fire();
                    levelDiceResult = -1;
            }
        }
    }
}
