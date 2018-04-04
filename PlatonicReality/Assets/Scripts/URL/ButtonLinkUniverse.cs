using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkUniverse : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("http://planetmath.org/PoincareDodecahedralSpace");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
