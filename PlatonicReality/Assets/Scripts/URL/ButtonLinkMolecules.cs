using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkMolecules : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://en.wikipedia.org/wiki/Tetrahedral_molecular_geometry");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
