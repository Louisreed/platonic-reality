using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class restartCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Disable AR camera
		DisableARCamera();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void DisableARCamera ()
	{
		CameraDevice.Instance.Deinit();
		CameraDevice.Instance.Stop();
	}
}
