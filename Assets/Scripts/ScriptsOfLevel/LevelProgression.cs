using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgression : MonoBehaviour
{
    //This is to display level 0 correctly
    public GameObject player;
    public GameObject mainMenu;

    public static float gameTime = 0;
    public float startingDistance = 0; // < -- This is to test the levels


    //These are the spawners of enemies of ice level and fire level
    //March, 16,2020. They need to be divided

    //Fire level spawns
    public ObjectIsActive enemySkulls;
    public ObjectIsActive rocks;
    public ObjectIsActive demonPillar;

    //Ice level spawns
    public ObjectIsActive enemyForest;
    public ObjectIsActive snowStalagmites;
    public ObjectIsActive snowMtn;

    //Cavern level spawns
    public ObjectIsActive shadowPillar;

    //Sewer level spawns
    public ObjectIsActive enemyTurtles;

    //City level spawns
    public ObjectIsActive roadBlocksCity;

    //Sea/sky level spawns
    public ObjectIsActive seaCannonTowers;

    //Heavenly level spawns
    public ObjectIsActive cherubEnemies;

    //Far realm spawns
    public ObjectIsActive fireGrass;
    public ObjectIsActive rockBank;

    //White void Spawns
    public ObjectIsActive blackHoleEnemies;

    //These are the spawners of enemies of greenfield level
    public ObjectIsActive whiteCloud;
    public ObjectIsActive grayStone;
    public ObjectIsActive greenBush;

    //Make levels Active
    public GameObject greenFieldLevel;
    public GameObject iceLevel;
    public GameObject fireLevel;
    public GameObject caveLevel;
    public GameObject sewerLevel;
    public GameObject cityLevel;
    public GameObject seaSkyLevel;
    public GameObject heavenlyLevel;
    public GameObject farRealmLevel;
    public GameObject whiteVoidLevel;

    //Game Texts
    public GameObject whiteTexts;
    public GameObject blackTexts;

    public float skullFrom = 500;
    public float skullTo = 900;
    public float skullEvery = 1000;

    public float forestFrom = 500;
    public float forestTo = 900;
    public float forestEvery = 0;

    public float cherubEnemyFrom = 500;
    public float cherubEnemyTo = 900;
    public float cherubEnemyEvery = 0;

    public float levelOne = 0;
    public float levelTwo = 3000;
    public float levelThree = 6000;
    public float levelFour = 9000;
    public float levelFive = 12000;
    public float levelSix = 15000;
    public float levelSeven = 18000;
    public float levelEight = 21000;
    public float levelNine = 24000;
    public float levelTen = 25000;

    public float gameEnd = 0;

    //Respite time between levels
    public float restTimeBetweenLvls = 10;

    public int isLevel = 1;
    public bool gameEnded = false;

    public GameResetter theGameResetter;

    // Use this for initialization
    void Start()
    {
        gameTime = startingDistance;
        player = GameObject.FindWithTag("Player");
    }

    public void GoToOne()
    {
        gameTime = 0;
        Pause.isPaused = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameTimer();
        LevelZero();
        LevelOne();
        GoToTwo();
        GoToThree();
        GoToFour();
        GoToFive();
        GoToSix();
        GoToSeven();
        GoToEight();
        GoToNine();
        GoToTen();
        GameTextColorToggle();
        LevelSwitcher();
    }

    void GameTextColorToggle()
    {
        if (isLevel == 10)
        {
            blackTexts.SetActive(true);
            whiteTexts.SetActive(false);
        }
        else if (isLevel == 0)
        {
            blackTexts.SetActive(false);
            whiteTexts.SetActive(false);
        }
        else
        {
            blackTexts.SetActive(false);
            whiteTexts.SetActive(true);
        }
    }

    void GameTimer()
    {
        if (!Pause.isPaused)
        {
            gameTime += Time.deltaTime;
        }
    }

    void LevelSwitcher()
    {
        if (gameTime < 0)
        {
            isLevel = 0;
        }

        if (gameTime >= levelOne)
        {
            isLevel = 1;
        }

        if (gameTime >= levelTwo)
        {
            isLevel = 2;
        }

        if (gameTime >= levelThree)
        {
            isLevel = 3;
        }

        if (gameTime >= levelFour)
        {
            isLevel = 4;
        }

        if (gameTime >= levelFive)
        {
            isLevel = 5;
        }

        if (gameTime >= levelSix)
        {
            isLevel = 6;
        }

        if (gameTime >= levelSeven)
        { 
            isLevel = 7;
        }

        if (gameTime >= levelEight)
        {
            isLevel = 8;
        }

        if (gameTime >= levelNine)
        {
            isLevel = 9;
        }

        if (gameTime >= levelTen)
        {
            isLevel = 10;
        }


        if (gameTime >= gameEnd)
        {
            theGameResetter.ResetGame();
        }
    }

    void LevelZero()
    {
        if (isLevel == 0)
        {

            greenFieldLevel.SetActive(false);
            iceLevel.SetActive(false);
            fireLevel.SetActive(false);
            caveLevel.SetActive(false);
            sewerLevel.SetActive(false);
            cityLevel.SetActive(false);
            seaSkyLevel.SetActive(false);
            heavenlyLevel.SetActive(false);
            farRealmLevel.SetActive(false);
            whiteVoidLevel.SetActive(false);

            player.SetActive(false);

            mainMenu.SetActive(true);
        }
        else
        {
            player.SetActive(true);
            blackTexts.SetActive(true);
            whiteTexts.SetActive(true);

            mainMenu.SetActive(false);
        }
    }
  
    void CallObject(ObjectIsActive obj, ref float to, ref float from, ref float every) 
    {
        if (gameTime >= from && gameTime <= to)
        {
            obj.isSpawned = true;
        }
        else if (gameTime >= to)
        {
            obj.isSpawned = false;
            from += every;
            to += every;
        }
    }

    //Make ice level active
    void GoToThree()
    {

        if (isLevel == 3)
        {

            //turn on ice level. 
            iceLevel.SetActive(true);

            snowMtn.isSpawned = true;
            snowStalagmites.isSpawned = true;
            CallObject(enemyForest, ref forestTo, ref forestFrom, ref forestEvery);

            //Give leeway to the next level. GameEnd will change as I build more levels
            if (gameTime >= (levelFour - restTimeBetweenLvls))
            {
                snowMtn.isSpawned = false;
                snowStalagmites.isSpawned = false;
            }

            //Turn off fire level
            //enemyForest.isSpawned = true;
            fireLevel.SetActive(false);
            demonPillar.isSpawned = false;
            rocks.isSpawned = false;
            demonPillar.isSpawned = false;
            rockBank.isSpawned = false;

        }
        else iceLevel.SetActive(false);
        
    }

//Make green level active
void LevelOne()
    {
        if (isLevel == 1)
        {
            greenFieldLevel.SetActive(true);

            //Turn green field active
            whiteCloud.isSpawned = true;
            grayStone.isSpawned = true;
            greenBush.isSpawned = true;


            if (gameTime >= (levelTwo - restTimeBetweenLvls))
            {
                //Turn green field active
                whiteCloud.isSpawned = false;
                grayStone.isSpawned = false;
                greenBush.isSpawned = false;
            }


            /*
             * March 16, 2020, TO-DO: Turn last level inactive to properly "loop" game
             * As of 3/16/2020, the last level is the "ice level":
            */

            //Change this later:
            whiteVoidLevel.SetActive(false);
        }
        else greenFieldLevel.SetActive(false);
        
    }

    //Make fire level active
    void GoToTwo()
    {
        if (isLevel == 2)
        {
            fireLevel.SetActive(true);

            //Turn on fire level
            rocks.isSpawned = true;
            demonPillar.isSpawned = true;
            CallObject(enemySkulls, ref skullTo, ref skullFrom, ref skullEvery);

            if (gameTime >= (levelThree - restTimeBetweenLvls))
            {
                rocks.isSpawned = false;
                demonPillar.isSpawned = false;
            }

            //Turn off green level
            greenFieldLevel.SetActive(false);
            whiteCloud.isSpawned = false;
            grayStone.isSpawned = false;
            greenBush.isSpawned = false;
        }
        else fireLevel.SetActive(false);
    }

    void GoToFour()
    {
        if (isLevel == 4)
        {
            caveLevel.SetActive(true);

            //Turn on cave level object scripts in the future... 4/7/2020
            //TO DO of cave level below here..
            shadowPillar.isSpawned = true;
            //TO DO of cave ends here...

            if (gameTime >= (levelFive - restTimeBetweenLvls))
            {
                //Turn off cave level object scripts in the future... 4/7/2020
                //TO DO off cave level below here..
                shadowPillar.isSpawned = false;
                //TO DO of cave ends here...
            }

            //Turn off cave level non-sccripted objects in the future... 4/7/2020
            iceLevel.SetActive(false);
        }
        else caveLevel.SetActive(false);
    }
    void GoToFive()
    {
        if (isLevel == 5)
        {
            sewerLevel.SetActive(true);
            enemyTurtles.isSpawned = true;
            //Turn on sewer level object scripts


            if (gameTime >= (levelSix - restTimeBetweenLvls))
            {
                //Turn off cave level object scripts in the future... 4/7/2020
                //TO DO off cave level below here..
                enemyTurtles.isSpawned = false;
                //TO DO of cave ends here...
            }

            //Turn off cave level non-sccripted objects in the future... 4/7/2020
            caveLevel.SetActive(false);
        }
        else sewerLevel.SetActive(false);
    }

    void GoToSix()
    {
        if (isLevel == 6)
        {
            cityLevel.SetActive(true);
            roadBlocksCity.isSpawned = true;
            //Turn on sewer level object scripts


            if (gameTime >= (levelSeven - restTimeBetweenLvls))
            {
                //Turn off cave level object scripts in the future... 4/7/2020
                //TO DO off cave level below here..
                roadBlocksCity.isSpawned = false;
                //TO DO of cave ends here...
            }

            //Turn off cave level non-sccripted objects in the future... 4/7/2020
            sewerLevel.SetActive(false);
        }
        else cityLevel.SetActive(false);
    }

    void GoToSeven()
    {
        if (isLevel == 7)
        {
            seaSkyLevel.SetActive(true);
            seaCannonTowers.isSpawned = true;
            //Turn on sewer level object scripts


            if (gameTime >= (levelEight - restTimeBetweenLvls))
            {
                //Turn off cave level object scripts in the future... 4/7/2020
                //TO DO off cave level below here..
                seaCannonTowers.isSpawned = false;
                //TO DO of cave ends here...
            }

            //Turn off cave level non-sccripted objects in the future... 4/7/2020
            cityLevel.SetActive(false);
        }
        else seaSkyLevel.SetActive(false);
    }

    void GoToEight()
    {
        if (isLevel == 8)
        {
            heavenlyLevel.SetActive(true);
            CallObject(cherubEnemies, ref cherubEnemyTo, ref cherubEnemyFrom, ref cherubEnemyEvery);
            //Turn on sewer level object scripts


            if (gameTime >= (levelNine - restTimeBetweenLvls))
            {
                //Turn off cave level object scripts in the future... 4/7/2020
                //TO DO off cave level below here..
                cherubEnemies.isSpawned = false;
                //TO DO of cave ends here...
            }

            //Turn off cave level non-sccripted objects in the future... 4/7/2020
            seaSkyLevel.SetActive(false);
        }
        else heavenlyLevel.SetActive(false);
    }
    void GoToNine()
    {
        if (isLevel == 9)
        {
            farRealmLevel.SetActive(true);
            //Turn on far realm level object scripts
            fireGrass.isSpawned = true;
            rockBank.isSpawned = true;

            if (gameTime >= (levelTen - restTimeBetweenLvls))
            {
                //Turn off far realm level  object scripts in the future... 4/7/2020
                //TO DO off far realm level below here..
                fireGrass.isSpawned = false;
                rockBank.isSpawned = false;
                //TO DO of far realm level  ends here...
            }

            //Turn off cave level non-sccripted objects in the future... 4/7/2020
            heavenlyLevel.SetActive(false);
        }
        else farRealmLevel.SetActive(false);
    }

    void GoToTen()
    {
        if (isLevel == 10)
        {
            whiteVoidLevel.SetActive(true);
            blackHoleEnemies.isSpawned = true;
            //Turn on far realm level object scripts


            if (gameTime >= (gameEnd - restTimeBetweenLvls))
            {
                //Turn off far realm level  object scripts in the future... 4/7/2020
                //TO DO off far realm level below here..
                blackHoleEnemies.isSpawned = false;
                //TO DO of far realm level  ends here...
            }

            //Turn off cave level non-sccripted objects in the future... 4/7/2020
            farRealmLevel.SetActive(false);
        }
        else whiteVoidLevel.SetActive(false);
    }
}
