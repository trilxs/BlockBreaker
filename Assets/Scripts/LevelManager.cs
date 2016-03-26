using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Ball.hasStarted = false;
		Application.LoadLevel (name);
	}
	
	public void LoadNextLevel() {
		Ball.hasStarted = false;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
