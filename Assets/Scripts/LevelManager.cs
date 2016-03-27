using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name) {
		LevelPrepare ();
		Application.LoadLevel (name);
	}
	
	public void LoadNextLevel() {
		LevelPrepare ();
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	public void LevelPrepare() {
		Ball.hasStarted = false;
		Brick.breakableCount = 0;
	}
	public void SimulateWin () {
		if (Brick.breakableCount <= 0) {
			if (Application.loadedLevel < 3) {
			LevelPrepare ();
				LoadNextLevel();
			}
			else {
				LoadLevel ("Win");
			}
		}
	}
}
