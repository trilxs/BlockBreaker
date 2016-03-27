using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static bool autoPlay = false;
	public static string difficulty;
	
	public void LoadLevel(string name) {
		LevelPrepare ();
		Application.LoadLevel (name);
	}
	
	public void LoadLevelEasy(string name) {
		LevelPrepare ();
		difficulty = "Easy";
		Application.LoadLevel (name);
	}
	
	public void LoadLevelMedium(string name) {
		LevelPrepare ();
		difficulty = "Medium";
		Application.LoadLevel (name);
	}
	
	public void LoadLevelHard(string name) {
		LevelPrepare ();
		difficulty = "Hard";
		Application.LoadLevel (name);
	}

	public void LoadAutoPlay(string name) {
		LevelPrepare ();
		autoPlay = true;
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
	
	public void Quit() {
		Application.Quit ();
	}
	
	public void SimulateWin () {
		if (Brick.breakableCount <= 0) {
			if (Application.loadedLevel < 3) {
			LevelPrepare ();
				LoadNextLevel();
			}
			else if (!autoPlay) {
				LoadLevel ("Win");
			}
			else {
				LoadLevel ("Autoplay");
			}
		}
	}
}
