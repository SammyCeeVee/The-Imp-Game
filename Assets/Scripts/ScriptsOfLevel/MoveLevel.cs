using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLevel : MonoBehaviour {

	public float ySpeed = 0;
    public float xSpeed = 0;

    public float snowYSpeed = 0;
    public float snowXSpeed = 0;

    public Renderer theFloor00;
    public Renderer theFloor01;
    public Renderer theFloor02;
    public Renderer theFloor03;
    public Renderer theFloor04;
    public Renderer theFloor05;
    public Renderer theFloor06;
    public Renderer theFloor07;
    public Renderer theFloor08;

    public Renderer theFallingSnow;
    public Renderer theFallingSnowCave;
    //Sewer level "floors"
    public Renderer sewerLeft;
    public Renderer sewerRight;
    public Renderer sewerCeiling;
    public Renderer sewerWater;

    //Void level "floors"
    public Renderer voidLevelSpeedLineLeft;
    public Renderer voidLevelSpeedLineRight;

    public bool isMovingStraight = true;
   

    void Update()
    {
        MoveStraight();
    }

    public void MoveStraight()

    {
        if (!Pause.isPaused)
        {
            if (isMovingStraight)
            {
                float yOffset = Time.time * ySpeed;
                float xOffset = Time.time * xSpeed;

                float snowXOffset = Time.time * snowXSpeed;
                float snowYOffset = Time.time * snowYSpeed;

                theFloor00.material.SetTextureOffset("_MainTex", new Vector2(0, -yOffset/16));
                theFloor01.material.SetTextureOffset("_MainTex", new Vector2(0, -yOffset));
                theFloor02.material.SetTextureOffset("_MainTex", new Vector2(0, -yOffset));
                theFloor03.material.SetTextureOffset("_MainTex", new Vector2(0, -yOffset));
                theFloor04.material.SetTextureOffset("_MainTex", new Vector2(0, -yOffset));
                theFloor05.material.SetTextureOffset("_MainTex", new Vector2(0, -yOffset));
                //This is the sea/sky level floor animation. Note that -yOffset is divided by 16 to slow it'speed.
                //This floor texture's y axis is also offset by a postive to make it look correct
                theFloor06.material.SetTextureOffset("_MainTex", new Vector2(0, yOffset/16));

                theFloor07.material.SetTextureOffset("_MainTex", new Vector2(0, yOffset));
                theFloor08.material.SetTextureOffset("_MainTex", new Vector2(0, yOffset));

                //Sewer level textures offsets
                sewerLeft.material.SetTextureOffset("_MainTex", new Vector2(xOffset, 0));
                sewerRight.material.SetTextureOffset("_MainTex", new Vector2(xOffset, 0));
                sewerCeiling.material.SetTextureOffset("_MainTex", new Vector2(xOffset, 0));
                sewerWater.material.SetTextureOffset("_MainTex", new Vector2(0, -yOffset));

                theFallingSnow.material.SetTextureOffset("_MainTex", new Vector2(snowXOffset, 
                    snowYOffset * 2));
                theFallingSnowCave.material.SetTextureOffset("_MainTex", new Vector2(snowXOffset,
                    snowYOffset * 2));

                //Sewer level textures offsets
                voidLevelSpeedLineLeft.material.SetTextureOffset("_MainTex", new Vector2(0, yOffset/3));
                voidLevelSpeedLineRight.material.SetTextureOffset("_MainTex", new Vector2(0, yOffset/3));
            }
        }
    }
}
