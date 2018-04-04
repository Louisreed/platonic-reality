using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkCardboard : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://vr.google.com/intl/en_uk/cardboard/get-cardboard/");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
