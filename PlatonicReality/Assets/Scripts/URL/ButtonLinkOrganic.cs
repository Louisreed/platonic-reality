﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkOrganic : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://en.wikipedia.org/wiki/Organic_compound");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
