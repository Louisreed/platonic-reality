using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkHistory : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://en.wikipedia.org/wiki/Platonic_solid#History");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
