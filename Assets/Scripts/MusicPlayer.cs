using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	
	void Awake () { //on wake because script execution order is Awake>Start>Update.
					//Therefore, there is a lag glitch if we code this on Start()
		if (instance != null) {
			Destroy (gameObject); //destroys the duplicate that is created 
		}
		else {
			instance = this; //instance is equal to the currently running song
			GameObject.DontDestroyOnLoad (gameObject); //makes sure it doesn't get destroyed
		}
	}
}

//http://gameprogrammingpatterns.com/singleton.html
//http://wiki.unity3d.com/index.php/Singleton
