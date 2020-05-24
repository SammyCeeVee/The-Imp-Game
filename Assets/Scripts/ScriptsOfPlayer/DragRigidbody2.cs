using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class DragRigidbody2 : MonoBehaviour
{
	
	public int normalCollisionCount = 1;
	public float moveLimit = .5f;
	public float collisionMoveFactor = .01f;
	public float addHeightWhenClicked = 0.0f;
	public bool freezeRotationOnDrag = true;
	public Camera cam;
	private Rigidbody myRigidbody ;
	private Transform myTransform  ;
	private bool canMove = false;
	private float zPos;
	private bool freezeRotationSetting ;
	private float sqrMoveLimit ;
	private int collisionCount = 0;
	private Transform camTransform;


    void Start()
    {
		myRigidbody = GetComponent<Rigidbody>();
		myTransform = transform;

		camTransform = cam.transform;
		sqrMoveLimit = moveLimit * moveLimit;   // Since we're using sqrMagnitude, which is faster than magnitude

	}

	public void Initiate()
    {
		//Old MouseDown
		canMove = true;
		myTransform.Translate(Vector3.forward * addHeightWhenClicked);
		freezeRotationSetting = myRigidbody.freezeRotation;
		myRigidbody.freezeRotation = freezeRotationOnDrag;
		zPos = myTransform.position.z;
	}




	/* The following code snippets are commented out and saved instead of deleted for design purposes. 
	  We may need this "OnMouseUp()" method later.
	 -- Samuel Caraballo Vazquez

		void OnMouseUp () 
		{
			canMove = false;
			myRigidbody.useGravity = gravitySetting;
			myRigidbody.freezeRotation = freezeRotationSetting;
			if (!myRigidbody.useGravity) 
		{
			Vector3 pos = myTransform.position;
			pos.y = yPos-addHeightWhenClicked;
					myTransform.position = pos;
		}	
		}*/


	void OnCollisionEnter () 
	{
		collisionCount++;
	}
	
	void OnCollisionExit () 
	{
		collisionCount--;
	}
	
	void FixedUpdate () 
	{
		if (!canMove)
		{
			return;
		}


		myRigidbody.velocity = Vector3.zero;
		myRigidbody.angularVelocity = Vector3.zero;
		
		Vector3 pos = myTransform.position;
		pos.z = zPos;
		myTransform.position = pos;

		Vector3 mousePos = Input.mousePosition;
		Vector3 move = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, camTransform.position.z - myTransform.position.z)) - myTransform.position;
		move.z = 0.0f;
		if (collisionCount > normalCollisionCount)		
		{
			move = move.normalized*collisionMoveFactor;
		}
		else if (move.sqrMagnitude > sqrMoveLimit) 
		{
			move = move.normalized*moveLimit;
		}
		
		myRigidbody.MovePosition(myRigidbody.position + move);
	}
}