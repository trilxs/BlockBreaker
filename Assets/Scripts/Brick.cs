using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private LevelManager levelManager;
	private int timesHit;
	
	void Start () {
	levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	void OnCollisionEnter2D(Collision2D col) {
		timesHit++;
		//SimulateWin();
	}
	
	void Update () {
		if (timesHit >= maxHits) {
			Destroy (gameObject);
		}
	}
	void SimulateWin() {
		if (Application.loadedLevel < 3) {
			levelManager.LoadNextLevel();
		}
		else {
			levelManager.LoadLevel ("Win");
		}
	}
}
