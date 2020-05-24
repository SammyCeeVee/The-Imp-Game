using UnityEngine;
using System.Collections;

public class MoveSky : MonoBehaviour {

		 
	public Skybox sky;
	public static float skySpeed = 1F; //A negative value here makes the sky rotate to the right
	float rot = 0;


	void Start() {
		sky = GetComponent<Skybox> ();
	}
	void Update () 
	{
		Flow();
	}

	public void Flow()
	{
		rot += 0 * Time.deltaTime + skySpeed;
		rot %= 360;
		sky.material.SetFloat ("_Rotation", rot);
	}
}
