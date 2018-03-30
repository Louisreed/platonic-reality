using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBackDodecahedron : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)){
			// Escape button pressed
			print("Escape");
			SceneManager.LoadScene("Dodecahedron", LoadSceneMode.Additive);
		}
	}
}
