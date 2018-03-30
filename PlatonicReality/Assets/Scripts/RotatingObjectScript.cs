using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObjectScript : MonoBehaviour {

	public float myRotationSpeed = 100.0f;

	public bool RotateX = false;
	public bool RotateY = false;
	public bool RotateZ = false;
	public bool positiveRotation = false;

	private int posOrNeg = 1;

	// Use this for initialization
	void Start ()
	{
		if(positiveRotation == false)
		{
			posOrNeg = -1;
		}
	}

	// Update is called once per frame
	void Update ()
	{
		//  Toggles X Rotation
		if(RotateX)
		{
			transform.Rotate(myRotationSpeed * Time.deltaTime * posOrNeg, 0, 0); //rotates object on X axis
			//Debug.Log("You are rotating on the X axis");	
		}
		//  Toggles Y Rotation
		if(RotateY)
		{
			transform.Rotate(0, myRotationSpeed * Time.deltaTime * posOrNeg, 0); //rotates object on Y axis
			//Debug.Log("You are rotating on the Y axis");
		}
		//  Toggles Z Rotation
		if(RotateZ)
		{
			transform.Rotate(0, 0, myRotationSpeed * Time.deltaTime * posOrNeg); //rotates object on Z axis
			//Debug.Log("You are rotating on the Z axis");
		}

	}

}