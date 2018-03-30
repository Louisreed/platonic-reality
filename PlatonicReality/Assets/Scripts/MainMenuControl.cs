using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour {

	public Button octahedronButton, hexahedronButton, icosahedronButton, dodecahedronButton;
	int levelPassed;

	// Use this for initialization
	void Start () {
		levelPassed = PlayerPrefs.GetInt ("LevelPassed");
		octahedronButton.interactable = false;
		hexahedronButton.interactable = false;
		icosahedronButton.interactable = false;
		dodecahedronButton.interactable = false;

		switch (levelPassed) {
		case 1:
			octahedronButton.interactable = true;
			break;
		case 2:
			hexahedronButton.interactable = true;
			break;
		case 3:
			icosahedronButton.interactable = true;
			break;
		case 4:
			dodecahedronButton.interactable = true;
			break;
		}
	}

	public void levelToLoad (int level)
	{
		SceneManager.LoadScene (level);
	}

	public void resetPlayerPrefs()
	{
		octahedronButton.interactable = false;
		hexahedronButton.interactable = false;
		icosahedronButton.interactable = false;
		dodecahedronButton.interactable = false;
		PlayerPrefs.DeleteAll ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
