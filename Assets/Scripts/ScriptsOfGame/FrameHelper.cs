using UnityEngine;
using System.Collections;

public class FrameHelper : MonoBehaviour {

	public int targetFrames = 60;
	
	void Awake () {
		Application.targetFrameRate = targetFrames;
	}
}
	
