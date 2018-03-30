using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientationPortrait : MonoBehaviour {

		public ScreenOrientation orientation = ScreenOrientation.Portrait;

	void Start () {

		Screen.orientation = orientation;
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
