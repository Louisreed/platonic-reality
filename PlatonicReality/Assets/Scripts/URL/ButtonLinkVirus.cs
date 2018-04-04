using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkVirus : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://en.wikipedia.org/wiki/Capsid");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
