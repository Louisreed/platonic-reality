using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkChlorophyll : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://onlinelibrary.wiley.com/doi/full/10.1107/S0907444904003233");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
