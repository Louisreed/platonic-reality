using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinkBubble : MonoBehaviour {

	public void OnURLPressed()
	{
		Application.OpenURL("https://en.wikipedia.org/wiki/Bubble_raft");
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
