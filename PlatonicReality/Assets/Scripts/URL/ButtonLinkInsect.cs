using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkInsect : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://en.wikipedia.org/wiki/Arthropod_eye");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
