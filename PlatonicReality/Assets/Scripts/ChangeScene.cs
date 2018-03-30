using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ChangeScene : MonoBehaviour {

	public void changeToScene(int changeTheScene){

		SceneManager.LoadScene (changeTheScene);
	}

}