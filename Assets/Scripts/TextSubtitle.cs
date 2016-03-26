using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextSubtitle : MonoBehaviour {
	public Text text;
	
	void Start () {
		text.text = "LEVEL " + Application.loadedLevel;
	}
	
	void Update() {
		if (Ball.hasStarted) {
			text.text = "";
		}
	}
}
