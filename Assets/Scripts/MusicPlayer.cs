using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	static MusicPlayer instance = null;
	
	void Start () {
		if (instance != null) {
			Destroy (gameObject); //destroys the duplicate that is created 
		}
		else {
			instance = this; //instance is equal to the currently running song
			GameObject.DontDestroyOnLoad (gameObject); //makes sure it doesn't get destroyed
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
